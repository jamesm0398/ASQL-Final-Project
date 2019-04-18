using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Timers;

namespace ASQL_Project_Display_Status
{
    public partial class Form1 : Form
    {
        SqlConnection con = null;
        private static System.Timers.Timer aTimer;

        public Form1()
        {
            InitializeComponent();

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Status_Conn"].ConnectionString;
                con = new SqlConnection(connectionString);
                con.Open();
                
            }

            catch
            {
                MessageBox.Show("Cannot connect to database");
            }
            

        }


        private void Run(object sender, ElapsedEventArgs e)
        {


            int harnessItems, reflectorItems, housingItems, lensItems, bulbItems, bezelItems;
            harnessItems = 0;
            reflectorItems = 0;
            housingItems = 0;
            lensItems = 0;
            bulbItems = 0;
            bezelItems = 0;


            //while (run == true)
            //{
            //    //get amount of each part in bin
            //    //for (int i = 1; i <= 6; i++)
            //    //{

            //    //    string command = "SELECT Amount FROM Parts WHERE PartID = " + i;
            //    //    //assemble a bulb
            //    //    SqlCommand getParts = new SqlCommand(command, con);

            //    //    SqlDataReader rdr = getParts.ExecuteReader();

            //    //    if (i == 1)
            //    //    {
            //    //        while (rdr.Read())
            //    //        {
            //    //            harnessItems = rdr.GetInt32(0);

            //    //        }
            //    //    }

            //    //    if (i == 2)
            //    //    {
            //    //        while (rdr.Read())
            //    //        {
            //    //            reflectorItems = rdr.GetInt32(0);

            //    //        }
            //    //    }

            //    //    if (i == 3)
            //    //    {
            //    //        while (rdr.Read())
            //    //        {
            //    //            housingItems = rdr.GetInt32(0);

            //    //        }
            //    //    }

            //    //    if (i == 4)
            //    //    {
            //    //        while (rdr.Read())
            //    //        {
            //    //            lensItems = rdr.GetInt32(0);

            //    //        }
            //    //    }

            //    //    if (i == 5)
            //    //    {
            //    //        while (rdr.Read())
            //    //        {
            //    //            bulbItems = rdr.GetInt32(0);

            //    //        }
            //    //    }

            //    //    if (i == 6)
            //    //    {
            //    //        while (rdr.Read())
            //    //        {
            //    //            bezelItems = rdr.GetInt32(0);

            //    //        }
            //    //    }

            //    //    harness.Text = harnessItems.ToString();
            //    //    reflector.Text = reflectorItems.ToString();
            //    //    housing.Text = housingItems.ToString();
            //    //    lens.Text = lensItems.ToString();
            //    //    bulb.Text = bulbItems.ToString();
            //    //    bezel.Text = bezelItems.ToString();


            //    //    rdr.Close();
            //    //    getParts.Dispose();
            //    //}




            //}

            for (int i = 0; i <= 6; i++)
            {
                string command2 = "SELECT Amount FROM Parts WHERE PartID = " + i;
                //assemble a bulb
                SqlCommand getParts2 = new SqlCommand(command2, con);

                SqlDataReader rdr2 = getParts2.ExecuteReader();

                if (i == 1)
                {
                    while (rdr2.Read())
                    {
                        harnessItems = rdr2.GetInt32(0);


                    }
                }

                if (i == 2)
                {
                    while (rdr2.Read())
                    {
                        reflectorItems = rdr2.GetInt32(0);


                    }
                }

                if (i == 3)
                {
                    while (rdr2.Read())
                    {
                        housingItems = rdr2.GetInt32(0);


                    }
                }

                if (i == 4)
                {
                    while (rdr2.Read())
                    {
                        lensItems = rdr2.GetInt32(0);


                    }
                }

                if (i == 5)
                {
                    while (rdr2.Read())
                    {
                        bulbItems = rdr2.GetInt32(0);


                    }
                }

                if (i == 6)
                {
                    while (rdr2.Read())
                    {
                        bezelItems = rdr2.GetInt32(0);


                    }
                }

                rdr2.Close();

            }


            string completedItems = "SELECT COUNT(TestUnitNum)  FROM TestTray";
            SqlCommand cmd_completed = new SqlCommand(completedItems, con);
            int completedTotal = (int)cmd_completed.ExecuteScalar();

            completed.Invoke((Action)delegate
            {
                completed.Text = completedTotal.ToString();

            });

            string faileditems = "SELECT COUNT(TestUnitNum)  FROM TestTray WHERE Passfail = 0";
            SqlCommand cmd_failed = new SqlCommand(faileditems, con);
            int failedNum = (int)cmd_failed.ExecuteScalar();

            failed.Invoke((Action)delegate
            {
                failed.Text = failedNum.ToString();

            });


            harness.Invoke((Action)delegate
            {
                harness.Text = harnessItems.ToString();
            });

            reflector.Invoke((Action)delegate
            {
                reflector.Text = reflectorItems.ToString();
            });

            housing.Invoke((Action)delegate
            {
                housing.Text = housingItems.ToString();
            });

            lens.Invoke((Action)delegate
            {
                lens.Text = lensItems.ToString();
            });

            bulb.Invoke((Action)delegate
            {
                bulb.Text = bulbItems.ToString();
            });

            bezel.Invoke((Action)delegate
            {
                bezel.Text = bezelItems.ToString();
            });

            //harness.Text = harnessItems.ToString();
            //reflector.Text = reflectorItems.ToString();
            //housing.Text = housingItems.ToString();
            //lens.Text = lensItems.ToString();
            //bulb.Text = bulbItems.ToString();
            //bezel.Text = bezelItems.ToString();
           


          //  con.Close();



        }

        private void Go(object sender, EventArgs e)
        {
            setTimer();

            
        }

        private void setTimer()
        {
            aTimer = new System.Timers.Timer(500);
            aTimer.Elapsed += Run;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;

        }

      

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }
    }
}
