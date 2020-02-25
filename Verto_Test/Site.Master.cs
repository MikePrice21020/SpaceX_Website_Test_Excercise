using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Verto_Test
{
    public partial class SiteMaster : MasterPage
    {
        string constr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\VertoData.mdf;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {

                using (SqlCommand cmd = new SqlCommand("SELECT Name, Link FROM HeaderButtons WHERE Id = 0"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        sdr.Read();
                        button1_Name.Text = sdr["Name"].ToString();
                        button1_Link.Text = sdr["Link"].ToString();
                    }
                }

                using (SqlCommand cmd = new SqlCommand("SELECT Name, Link FROM HeaderButtons WHERE Id = 1"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        sdr.Read();
                        button2_Name.Text = sdr["Name"].ToString();
                        button2_Link.Text = sdr["Link"].ToString();
                    }
                }
                using (SqlCommand cmd = new SqlCommand("SELECT Name, Link FROM HeaderButtons WHERE Id = 2"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        sdr.Read();
                        button3_Name.Text = sdr["Name"].ToString();
                        button3_Link.Text = sdr["Link"].ToString();
                    }
                }
                using (SqlCommand cmd = new SqlCommand("SELECT Name, Link FROM HeaderButtons WHERE Id = 3"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        sdr.Read();
                        button4_Name.Text = sdr["Name"].ToString();
                        button4_Link.Text = sdr["Link"].ToString();
                    }
                }
                using (SqlCommand cmd = new SqlCommand("SELECT Name, Link FROM HeaderButtons WHERE Id = 4"))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        sdr.Read();
                        button5_Name.Text = sdr["Name"].ToString();
                        button5_Link.Text = sdr["Link"].ToString();
                    }
                }
                con.Close();
            }
        }
    }
}