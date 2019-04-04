using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace ASQL_Project_Workstation
{
    public partial class Form1 : Form
    {


        SqlConnection conn = null;
        bool runWorkstation = false;
        int completedUnits = 0;
        int testTrayUnits = 0;
        int failedItems = 0;
        private int stationNumber = 0;

        public Form1()
        {
            InitializeComponent();

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Workstation_Conn"].ConnectionString;
                conn = new SqlConnection(connectionString);
                conn.Open();
            }

            catch
            {
                MessageBox.Show("Cannot connect to database");
            }

        }


        

        //RunStation(): Method to run and setup a workstation 
        //Params: int station: the station number, needed for specifying each worker's experience level
        //Returns: none
        public void RunStation()
        {
            

            runWorkstation = true;
            int orders = 300; //hard coded for now
            stationNumber++;




            SqlCommand getExperience = new SqlCommand("GetExperiences", conn);
            getExperience.CommandType = CommandType.StoredProcedure;

            
            getExperience.Parameters.Add("@StationNum", SqlDbType.Int, 50).Value = stationNumber;
            getExperience.Parameters.Add("@ExpLevel", SqlDbType.Int).Direction = ParameterDirection.Output;
            getExperience.ExecuteReader();
            int expLevel = Convert.ToInt32(getExperience.Parameters["@ExpLevel"].Value);
            
         



            string ts = "SELECT TimeScale FROM Config";
            SqlCommand getTimescale = new SqlCommand(ts, conn);
            int timescale = (int)getTimescale.ExecuteScalar();

          
            int timeToComplete = 60; //TIME to complete lamp (60 secs)
            double defectRate = 0;//defect rate depending on experience


            if(expLevel == 1)
            {
                timeToComplete = 90;
                defectRate = 0.85;
            }

            if(expLevel == 3)
            {
                timeToComplete = 51;
                defectRate = 0.15;
            }

            if(expLevel == 2)
            {
                Random rnd = new Random();
                timeToComplete = rnd.Next(54, 66); //since the time to complete is 60 secs +/- 10%, their time to complete is between 54 and 66 secs
                defectRate = 0.5;
            }

            timeToComplete = timeToComplete / timescale; //actual time to complete depends on timescale


            bool harnessHasCard = false;
            bool reflectorHasCard = false;
            bool housingHasCard = false;
            bool lensHasCard = false;
            bool bulbHasCard = false;
            bool bezelHasCard = false;

            int timer = 0;
            int sleepTime = 100*timeToComplete;
            int harnessItems, reflectorItems, housingItems, lensItems, bulbItems, bezelItems;
            harnessItems = reflectorItems = housingItems = lensItems = bulbItems = bezelItems = 0;
            int testTrayNum = 1;
            string testUnitNum = "";
            bool testBulbIsGood = true;

            Random defectChance = new Random();


            while (runWorkstation == true && completedUnits != orders)
            {
                //save the time to complete so it can be reset later
               // int timeToCompleteInitially = timeToComplete;

                

                

                    //get amount of each part in bin
                    for (int i = 1; i <= 6; i++)
                    {
                        //assemble a bulb
                        SqlCommand getParts = new SqlCommand("GetPartsLeft", conn);
                        getParts.CommandType = CommandType.StoredProcedure;

                        getParts.Parameters.Add("@partID", SqlDbType.Int, 50).Value = i;
                        getParts.Parameters.Add("@partsLeft", SqlDbType.Int).Direction = ParameterDirection.Output;
                        getParts.ExecuteReader();

                        switch (i)
                        {
                            case 1:
                                harnessItems = Convert.ToInt32(getParts.Parameters["@partsLeft"].Value);
                                harnessLeft.Text = harnessItems.ToString();
                                if(harnessItems <= 5)
                                {
                                    harnessHasCard = true;
                                    
                                }
                                continue;

                            case 2:
                                reflectorItems = Convert.ToInt32(getParts.Parameters["@partsLeft"].Value);
                                reflectorLeft.Text = reflectorItems.ToString();
                                if (reflectorItems <= 5)
                                {
                                    reflectorHasCard = true;
                                    
                                }
                                continue;

                            case 3:
                                housingItems = Convert.ToInt32(getParts.Parameters["@partsLeft"].Value);
                                housingLeft.Text = housingItems.ToString();
                                if (housingItems <= 5)
                                {
                                    housingHasCard = true;
                                   

                                }
                                continue;

                            case 4:
                                lensItems = Convert.ToInt32(getParts.Parameters["@partsLeft"].Value);
                                lensLeft.Text = lensItems.ToString();
                                if (lensItems <= 5)
                                {
                                    lensHasCard = true;
                                  
                                }
                                continue;

                            case 5:
                                bulbItems = Convert.ToInt32(getParts.Parameters["@partsLeft"].Value);
                                bulbLeft.Text = bulbItems.ToString();
                                if (bulbItems <= 5)
                                {
                                    bulbHasCard = true;
                                 
                                }
                                continue;

                            case 6:
                                bezelItems = Convert.ToInt32(getParts.Parameters["@partsLeft"].Value);
                                bezelLeft.Text = bezelItems.ToString();
                                if (bezelItems <= 5)
                                {
                                    bezelHasCard = true;
                                   
                                }
                                continue;

                                
                    
                        }

                        getParts.Parameters.Clear();

                        

                    }

                    //decrement each bin by one part
                    SqlCommand decrementParts = new SqlCommand("UpdateParts", conn);
                    decrementParts.CommandType = CommandType.StoredProcedure;

                    for (int p = 1; p <=6; p++)
                    {
                        decrementParts.Parameters.Add("@partID", SqlDbType.Int, 50).Value = p;
                        decrementParts.ExecuteNonQuery();
                        decrementParts.Parameters.Clear();
                    }

                 
                    timer = timer + timescale;
                    

                    //replace bins (every 5 mins)
                    if (timer == 300)
                    {
                       
                        if(harnessHasCard == true)
                        {
                            RefillBins(1, harnessItems);
                        }

                        if (reflectorHasCard == true)
                        {
                            RefillBins(2, reflectorItems);
                        }

                        if (housingHasCard == true)
                        {
                            RefillBins(3, housingItems);
                        }

                        if (lensHasCard == true)
                        {
                            RefillBins(4, lensItems);
                        }

                        if (bulbHasCard == true)
                        {
                            RefillBins(5, bulbItems);
                        }

                        if (bezelHasCard == true)
                        {
                            RefillBins(6, bezelItems);
                        }

                    }

               

                async void wait()
                {
                    await Task.Delay(sleepTime);
                }

                 //   System.Threading.Thread.Sleep(sleepTime);
                

              //  timeToComplete = timeToCompleteInitially;

                if(defectChance.Next(100) < defectRate)
                {
                    testBulbIsGood = false;
                    failedItems++;
                }
                
                //add bulb to test tray
                testTrayUnits++;
            
                //test tray is full
                if (testTrayUnits == 60)
                {
                    testTrayNum++;
                }

                testTrayNum.ToString("000000");
                int bulbGood = testBulbIsGood ? 1 : 0;

                testUnitNum = "FL" + testTrayNum + testTrayUnits;
                SqlCommand insertUnitNum = new SqlCommand();
                insertUnitNum.Connection = conn;
                insertUnitNum.CommandText = "INSERT INTO TestTray (TestUnitNum, PassFail) VALUES (@TU, @PF)";
                insertUnitNum.Prepare();
                insertUnitNum.Parameters.AddWithValue("@TU", testUnitNum);
                insertUnitNum.Parameters.AddWithValue("@PF", bulbGood);
                insertUnitNum.ExecuteNonQuery();

              

                timer = timer + timescale;
                completedUnits++;

                wait();

                // System.Threading.Thread.Sleep(sleepTime);

            }

            doneLabel.Text = "Orders filled";

            conn.Close();
        }

        //RefillBins(): Called when the bin has less than 5 items left, this is simulating the runner replacing the bin
        //Parameters: int part: the part ID of the part to replenish, int itemsLeft: the number of items left over, to add on top of the new bin
        //Returns: none
        public void RefillBins(int part, int itemsLeft)
        {
            SqlCommand refill = new SqlCommand("ReplenishBins", conn);
            refill.CommandType = CommandType.StoredProcedure;
            refill.Parameters.Add("@partID", SqlDbType.Int, 50).Value = part;
            refill.Parameters.Add("@partsLeft", SqlDbType.Int, 50).Value = itemsLeft;
            refill.ExecuteNonQuery();
        }
       

        public void StopStation()
        {
            runWorkstation = false;
            stationNumber--;
        }


        private void run1_Click(object sender, EventArgs e)
        {
            RunStation();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            StopStation();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
