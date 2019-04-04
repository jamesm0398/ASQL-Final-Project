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

namespace ASQL_Project_Display_Status
{
    public partial class Form1 : Form
    {
        SqlConnection conn = null;

        public Form1()
        {
            InitializeComponent();

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Status_Conn"].ConnectionString;
                conn = new SqlConnection(connectionString);
                conn.Open();
                Run();
            }

            catch
            {
                MessageBox.Show("Cannot connect to database");
            }
          
            

        }


        public void Run()
        {  


            int harnessItems, reflectorItems, housingItems, lensItems, bulbItems, bezelItems;
            harnessItems = reflectorItems = housingItems = lensItems = bulbItems = bezelItems = 0;
            bool run = true;

            while (run == true)
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
                            harness.Text = harnessItems.ToString();
                            //if (harnessItems <= 5)
                            //{
                            //    harnessHasCard = true;

                            //}
                            continue;

                        case 2:
                            reflectorItems = Convert.ToInt32(getParts.Parameters["@partsLeft"].Value);
                            reflector.Text = reflectorItems.ToString();
                            //if (reflectorItems <= 5)
                            //{
                            //    reflectorHasCard = true;

                            //}
                            continue;

                        case 3:
                            housingItems = Convert.ToInt32(getParts.Parameters["@partsLeft"].Value);
                            housing.Text = housingItems.ToString();
                            //if (housingItems <= 5)
                            //{
                            //    housingHasCard = true;


                            //}
                            continue;

                        case 4:
                            lensItems = Convert.ToInt32(getParts.Parameters["@partsLeft"].Value);
                            lens.Text = lensItems.ToString();
                            //if (lensItems <= 5)
                            //{
                            //    lensHasCard = true;

                            //}
                            continue;

                        case 5:
                            bulbItems = Convert.ToInt32(getParts.Parameters["@partsLeft"].Value);
                            bulb.Text = bulbItems.ToString();
                            //if (bulbItems <= 5)
                            //{
                            //    bulbHasCard = true;

                            //}
                            continue;

                        case 6:
                            bezelItems = Convert.ToInt32(getParts.Parameters["@partsLeft"].Value);
                            bezel.Text = bezelItems.ToString();
                            //if (bezelItems <= 5)
                            //{
                            //    bezelHasCard = true;

                            //}
                            continue;



                    }

                    getParts.Parameters.Clear();
                }


           



            }
            conn.Close();



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
