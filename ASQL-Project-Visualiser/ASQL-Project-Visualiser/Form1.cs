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
using System.Windows.Forms.DataVisualization.Charting;

namespace ASQL_Project_Visualiser
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
                string connectionString = ConfigurationManager.ConnectionStrings["Visual_Conn"].ConnectionString;
                con = new SqlConnection(connectionString);
                con.Open();

            }

            catch
            {
                MessageBox.Show("Cannot connect to database");
            }

        }


        private void Run(object sender, EventArgs e)
        {
            int harnessItems, reflectorItems, housingItems, lensItems, bulbItems, bezelItems;
            harnessItems = 0;
            reflectorItems = 0;
            housingItems = 0;
            lensItems = 0;
            bulbItems = 0;
            bezelItems = 0;



            DataTable tbl = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter();


            string command = "SELECT * FROM Parts";
            SqlCommand cmd = new SqlCommand(command, con);
            adp.SelectCommand = cmd;
            adp.Fill(tbl);

            for (int i = 0; i <= 6; i++)
            {
                string command2 = "SELECT Amount FROM Parts WHERE PartID = " + i;
                //assemble a bulb
                SqlCommand getParts = new SqlCommand(command2, con);

                SqlDataReader rdr2 = getParts.ExecuteReader();

                if (i == 1)
                {
                    while (rdr2.Read())
                    {
                        harnessItems = rdr2.GetInt32(0);
                        if(harnessItems < 5)
                        {
                            harness.Text = "REPLACE HARNESSES";
                        }

                        else
                        {
                            harness.Text = "";
                        }


                    }
                }

                if (i == 2)
                {
                    while (rdr2.Read())
                    {
                        reflectorItems = rdr2.GetInt32(0);
                        if (reflectorItems < 5)
                        {
                            reflector.Text = "REPLACE REFLECTORS";
                        }
                        else
                        {
                            reflector.Text = "";
                        }


                    }
                }

                if (i == 3)
                {
                    while (rdr2.Read())
                    {
                        housingItems = rdr2.GetInt32(0);
                        if (housingItems < 5)
                        {
                            housing.Text = "REPLACE HOUSINGS";
                        }
                        else
                        {
                            housing.Text = "";
                        }



                    }
                }

                if (i == 4)
                {
                    while (rdr2.Read())
                    {
                        lensItems = rdr2.GetInt32(0);
                        if (lensItems < 5)
                        {
                            lens.Text = "REPLACE LENSES";
                        }
                        else
                        {
                            lens.Text = "";
                        }


                    }
                }

                if (i == 5)
                {
                    while (rdr2.Read())
                    {
                        bulbItems = rdr2.GetInt32(0);
                        if (bulbItems < 5)
                        {
                            bulb.Text = "REPLACE BULBS";
                        }
                        else
                        {
                            bulb.Text = "";
                        }



                    }
                }

                if (i == 6)
                {
                    while (rdr2.Read())
                    {
                        bezelItems = rdr2.GetInt32(0);
                        if (bezelItems < 5)
                        {
                            bezel.Text = "REPLACE BEZELS";
                        }
                        else
                        {
                            bezel.Text = "";
                        }


                    }
                }

                rdr2.Close();

            }

           


            this.KanbanGraph.DataSource = tbl;
            this.KanbanGraph.Series[0].XValueMember = "PartName";
            this.KanbanGraph.Series[0].YValueMembers = "Amount";
            this.KanbanGraph.DataBind();
        }

        private void run_Click(object sender, EventArgs e)
        {
            setTimer();
        }

        private void setTimer()
        {
            Timer aTimer = new Timer();
            aTimer.Tick += new EventHandler (Run);
            aTimer.Interval = 500;
            aTimer.Start();

        }
    }
}
