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
using System.Windows.Forms;

namespace ASQL_Project_Workstation
{
    public partial class Form1 : Form
    {


        SqlConnection conn = null;
        bool runWorkstation = false;
        int completedUnits = 0;
        int testTrayUnits = 0;
        int failedItems = 0;
        int stationNum = 0;
        int sleepTime = 0;
        int timer = 0;


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
        public void RunStation(object sender, EventArgs e)
        {


            runWorkstation = true;

            int orders = Convert.ToInt32(numOrders.Text);


            SqlCommand getExperience = new SqlCommand("GetExperiences", conn);
            getExperience.CommandType = CommandType.StoredProcedure;

            
            getExperience.Parameters.Add("@StationNum", SqlDbType.Int, 50).Value = GetStationNum();
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

            
           
            int harnessItems, reflectorItems, housingItems, lensItems, bulbItems, bezelItems;
            harnessItems = reflectorItems = housingItems = lensItems = bulbItems = bezelItems = 0;
            int testTrayNum = 1;
            string testUnitNum = "";
            bool testBulbIsGood = true;

            Random defectChance = new Random();


          
                //save the time to complete so it can be reset later
                // int timeToCompleteInitially = timeToComplete;

                

                if(GetWorkStnStatus() == true)
            {
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

                            if (harnessItems <= 5)
                            {
                                harnessHasCard = true;

                            }

                           

                            continue;

                        case 2:
                            reflectorItems = Convert.ToInt32(getParts.Parameters["@partsLeft"].Value);

                            if (reflectorItems <= 5)
                            {
                                reflectorHasCard = true;

                            }

                         
                            continue;

                        case 3:
                            housingItems = Convert.ToInt32(getParts.Parameters["@partsLeft"].Value);

                            if (housingItems <= 5)
                            {
                                housingHasCard = true;


                            }

                           

                            continue;

                        case 4:
                            lensItems = Convert.ToInt32(getParts.Parameters["@partsLeft"].Value);

                            if (lensItems <= 5)
                            {
                                lensHasCard = true;

                            }

                          
                            continue;

                        case 5:
                            bulbItems = Convert.ToInt32(getParts.Parameters["@partsLeft"].Value);

                            if (bulbItems <= 5)
                            {
                                bulbHasCard = true;

                            }

                           

                            continue;

                        case 6:
                            bezelItems = Convert.ToInt32(getParts.Parameters["@partsLeft"].Value);

                            if (bezelItems <= 5)
                            {
                                bezelHasCard = true;

                            }

                           
                            continue;



                    }

                    getParts.Parameters.Clear();



                }

                
                if(harnessItems > 0 && housingItems > 0 && lensItems > 0 && bulbItems > 0 && bezelItems > 0 && reflectorItems > 0)
                {
                    for(int r = 0; r <=6; r++)
                    {
                        SqlCommand decrementParts = new SqlCommand("UpdateParts", conn);
                        decrementParts.CommandType = CommandType.StoredProcedure;
                        decrementParts.Parameters.Add("@partID", SqlDbType.Int, 50).Value = r;
                        decrementParts.ExecuteNonQuery();
                        decrementParts.Parameters.Clear();
                    }
                    completedUnits++;
                }
              


                //replace bins (every 5 mins)
                if (IncrementTimer(timeToComplete) % 100 == 0)
                {

                    if (harnessHasCard == true)
                    {
                        RefillBins(1, harnessItems);
                        harnessHasCard = false;
                    }

                    if (reflectorHasCard == true)
                    {
                        RefillBins(2, reflectorItems);
                        reflectorHasCard = false;
                    }

                    if (housingHasCard == true)
                    {
                        RefillBins(3, housingItems);
                        housingHasCard = false;
                    }

                    if (lensHasCard == true)
                    {
                        RefillBins(4, lensItems);
                        lensHasCard = false;
                    }

                    if (bulbHasCard == true)
                    {
                        RefillBins(5, bulbItems);
                        bulbHasCard = false;
                    }

                    if (bezelHasCard == true)
                    {
                        RefillBins(6, bezelItems);
                        bezelHasCard = false;
                    }

                }





            

                if (defectChance.Next(100) < defectRate)
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




       


            }

                
            if(completedUnits == orders)
            {
                doneLabel.Text = "Orders filled";
            }
      

          //  conn.Close();
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

        public int IncrementTimer(int timeToComplete)
        {
           
           this.timer = this.timer + timeToComplete;
           this.timer = 10 * ((this.timer + 9) / 10);
            return this.timer;
        }

     

        public int GetTimescale()
        {

            string ts = "SELECT TimeScale FROM Config";
            SqlCommand getTimescale = new SqlCommand(ts, conn);
            int timescale = (int)getTimescale.ExecuteScalar();
            return timescale;
        }

       

        public bool GetWorkStnStatus()
        {
            return this.runWorkstation;
        }

        public int GetStationNum()
        {
            return this.stationNum;
        }

        public void SetStationNum(int num)
        {
            this.stationNum = num;
        }

        public void SetSleepTime ()
        {
            SqlCommand getExperience = new SqlCommand("GetExperiences", conn);
            getExperience.CommandType = CommandType.StoredProcedure;


            getExperience.Parameters.Add("@StationNum", SqlDbType.Int, 50).Value = GetStationNum();
            getExperience.Parameters.Add("@ExpLevel", SqlDbType.Int).Direction = ParameterDirection.Output;
            getExperience.ExecuteReader();
            int expLevel = Convert.ToInt32(getExperience.Parameters["@ExpLevel"].Value);





            string ts = "SELECT TimeScale FROM Config";
            SqlCommand getTimescale = new SqlCommand(ts, conn);
            int timescale = (int)getTimescale.ExecuteScalar();


            int timeToComplete = 60; //TIME to complete lamp (60 secs)
          

            if (expLevel == 1)
            {
                timeToComplete = 90;
              
            }

            if (expLevel == 3)
            {
                timeToComplete = 51;
             
            }

            if (expLevel == 2)
            {
                Random rnd = new Random();
                timeToComplete = rnd.Next(54, 66); //since the time to complete is 60 secs +/- 10%, their time to complete is between 54 and 66 secs
                
            }

            timeToComplete = timeToComplete / timescale; //actual time to complete depends on timescale
            this.sleepTime = timeToComplete*1000;
        }

        public int GetSleepTime()
        {
            return this.sleepTime;
        }


        private void run1_Click(object sender, EventArgs e)
        {
            SetStationNum(1);
            SetSleepTime();
            Timer aTimer = new Timer();
            aTimer.Tick += new EventHandler(RunStation);
            aTimer.Interval = GetSleepTime();
            aTimer.Start();



           
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void run2_Click(object sender, EventArgs e)
        {
            SetStationNum(2);
            SetSleepTime();
            Timer aTimer = new Timer();
            aTimer.Tick += new EventHandler(RunStation);
            aTimer.Interval = GetSleepTime();
            aTimer.Start();
        }

        private void run3_Click(object sender, EventArgs e)
        {
            SetStationNum(3);
            SetSleepTime();
            Timer aTimer = new Timer();
            aTimer.Tick += new EventHandler(RunStation);
            aTimer.Interval = GetSleepTime();
            aTimer.Start();
        }
    }
}
