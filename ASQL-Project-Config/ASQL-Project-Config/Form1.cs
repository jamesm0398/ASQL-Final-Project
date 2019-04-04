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
using MySql.Data.MySqlClient;
using System.Configuration;

//This program allows for configuration of the Kanban System


namespace ASQL_Project_Config
{
    public partial class Form1 : Form
    {
        SqlConnection conn = null;

        public Form1()
        {
            InitializeComponent();

            station1Box.Items.Add("New/Rookie");
            station1Box.Items.Add("Normal");
            station1Box.Items.Add("Very Experienced");
            station2Box.Items.Add("New/Rookie");
            station2Box.Items.Add("Normal");
            station2Box.Items.Add("Very Experienced");
            station3Box.Items.Add("New/Rookie");
            station3Box.Items.Add("Normal");
            station3Box.Items.Add("Very Experienced");


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                string connString = ConfigurationManager.ConnectionStrings["KanbanConnection"].ConnectionString;
                conn = new SqlConnection(connString);
                conn.Open();
            }

            catch
            {
                MessageBox.Show("Unable to connect to database.");
            }

          
            //reset database so previous configurations are forgotten about
            SqlCommand reset = new SqlCommand("ResetDB", conn);
            reset.CommandType = CommandType.StoredProcedure;
            reset.ExecuteNonQuery();

            string stn1 = station1Box.Text;
            string stn2 = station2Box.Text;
            string stn3 = station3Box.Text;


            int stn1Experience = 0;
            int stn2Experience = 0;
            int stn3Experience = 0;

            if(stn1 == "New/Rookie")
            {
                stn1Experience = 1;
            }

            if(stn1 == "Normal")
            {
                stn1Experience = 2;

            }

            if(stn1 == "Very Experienced")
            {
                stn1Experience = 3;
            }

            if (stn2 == "New/Rookie")
            {
                stn2Experience = 1;
            }

            if (stn2 == "Normal")
            {
                stn2Experience = 2;

            }

            if (stn2 == "Very Experienced")
            {
                stn2Experience = 3;
            }

            if (stn3 == "New/Rookie")
            {
                stn3Experience = 1;
            }

            if (stn3 == "Normal")
            {
                stn3Experience = 2;

            }

            if (stn3 == "Very Experienced")
            {
                stn3Experience = 3;
            }

            SqlCommand insertExperiences = new SqlCommand();
            insertExperiences.Connection = conn;
            insertExperiences.CommandText = "INSERT INTO Config (TimeScale, Station1Experience, Station2Experience, Station3Experience) VALUES (@TS, @S1, @S2, @S3)";
            insertExperiences.Parameters.AddWithValue("@TS", timescale.Text);
            insertExperiences.Parameters.AddWithValue("@S1", stn1Experience);
            insertExperiences.Parameters.AddWithValue("@S2", stn2Experience);
            insertExperiences.Parameters.AddWithValue("@S3", stn3Experience);

            insertExperiences.ExecuteNonQuery();


            //****USE TO GET EXPERIENCE IN WORKSTATION***
            //SqlCommand getExp1 = new SqlCommand("GetExperiences", conn);
            //getExp1.CommandType = CommandType.StoredProcedure;
            //getExp1.Parameters.Add("@StationNum", SqlDbType.Int, 50).Value = 1;
            //getExp1.Parameters.Add("@ExpLevel", SqlDbType.Int).Direction = ParameterDirection.Output;
            //getExp1.ExecuteReader();
            //stn1Exp.Text = Convert.ToString(getExp1.Parameters["@ExpLevel"].Value);

            //SqlCommand addTimescale = new SqlCommand();
            //addTimescale.Connection = conn;
            //addTimescale.CommandText = "INSERT INTO Config (TimeScale) VALUES (@TS)";
            //addTimescale.Parameters.AddWithValue("@TS", timescale.Text);
            //addTimescale.ExecuteNonQuery();

            //**USE TO GET TIMESCALE IN WORKSTATION***
            //string ts = "SELECT TimeScale FROM Config";
            //SqlCommand getTimescale = new SqlCommand(ts,conn);
            
            //int timescaleINT = 0;

            //timescaleINT = (int)getTimescale.ExecuteScalar();

            //stn2Exp.Text = timescaleINT.ToString();
  

            conn.Close();

        }

        
    }
}
