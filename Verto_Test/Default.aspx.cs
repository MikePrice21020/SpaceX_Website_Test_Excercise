using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Verto_Test
{
    public partial class _Default : Page
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        string constr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\VertoData.mdf;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                using (SqlConnection con = new SqlConnection(constr))
                {

                    // LOAD 4 orbit headers and Image paths
                    using (SqlCommand cmd = new SqlCommand("SELECT Id, Header, ImgPath FROM Orbit WHERE Id = 0"))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        con.Open();
                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            sdr.Read();
                            orbit1_Header.Text = sdr["Header"].ToString();
                            orbit1_ImgPath.Text = sdr["ImgPath"].ToString();
                        }
                    }

                    using (SqlCommand cmd = new SqlCommand("SELECT Id, Header, ImgPath FROM Orbit WHERE Id = 1"))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            sdr.Read();
                            orbit2_Header.Text = sdr["Header"].ToString();
                            orbit2_ImgPath.Text = sdr["ImgPath"].ToString();
                        }
                    }

                    using (SqlCommand cmd = new SqlCommand("SELECT Id, Header, ImgPath FROM Orbit WHERE Id = 2"))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            sdr.Read();
                            orbit3_Header.Text = sdr["Header"].ToString();
                            orbit3_ImgPath.Text = sdr["ImgPath"].ToString();
                        }
                    }

                    using (SqlCommand cmd = new SqlCommand("SELECT Id, Header, ImgPath FROM Orbit WHERE Id = 3"))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            sdr.Read();
                            orbit4_Header.Text = sdr["Header"].ToString();
                            orbit4_ImgPath.Text = sdr["ImgPath"].ToString();
                        }
                    }



                    //Load Page Content
                    using (SqlCommand cmd = new SqlCommand("SELECT Id, Header, ImgPath, Content FROM PageContent WHERE Id = 0"))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            sdr.Read();
                            product_Header.Text = sdr["Header"].ToString();
                            product_ImgPath.Text = sdr["ImgPath"].ToString();
                            product_Content.Text = sdr["Content"].ToString();
                        }
                    }
                    using (SqlCommand cmd = new SqlCommand("SELECT Id, Header, ImgPath, Content FROM PageContent WHERE Id = 1"))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            sdr.Read();
                            event_Header.Text = sdr["Header"].ToString();
                            event_ImgPath.Text = sdr["ImgPath"].ToString();
                            event_Content.Text = sdr["Content"].ToString();
                        }
                    }
                    using (SqlCommand cmd = new SqlCommand("SELECT Id, Header, ImgPath, Content FROM PageContent WHERE Id = 2"))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            sdr.Read();
                            news_Header.Text = sdr["Header"].ToString();
                            news_ImgPath.Text = sdr["ImgPath"].ToString();
                            news_Content.Text = sdr["Content"].ToString();
                        }
                    }
                    using (SqlCommand cmd = new SqlCommand("SELECT Id, Header, ImgPath, Content FROM PageContent WHERE Id = 3"))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            sdr.Read();
                            gallery_Header.Text = sdr["Header"].ToString();
                            gallery_ImgPath.Text = sdr["ImgPath"].ToString();
                            gallery_Content.Text = sdr["Content"].ToString();
                        }
                    }

                    // Special offers

                    using (SqlCommand cmd = new SqlCommand("SELECT Id, Header, ImgPath, Content FROM PageContent WHERE Id = 4"))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            sdr.Read();
                            cashback_Header.Text = sdr["Header"].ToString();
                            cashback_ImgPath.Text = sdr["ImgPath"].ToString();
                            cashback_Content.Text = sdr["Content"].ToString();
                        }
                    }
                    using (SqlCommand cmd = new SqlCommand("SELECT Id, Header, ImgPath, Content FROM PageContent WHERE Id = 5"))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            sdr.Read();
                            fieldscopes_Header.Text = sdr["Header"].ToString();
                            fieldscopes_ImgPath.Text = sdr["ImgPath"].ToString();
                            fieldscopes_Content.Text = sdr["Content"].ToString();
                        }
                    }
                    using (SqlCommand cmd = new SqlCommand("SELECT Id, Header, ImgPath, Content FROM PageContent WHERE Id = 6"))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            sdr.Read();
                            fieldscopekit_Header.Text = sdr["Header"].ToString();
                            fieldscopekit_ImgPath.Text = sdr["ImgPath"].ToString();
                            fieldscopekit_Content.Text = sdr["Content"].ToString();
                        }
                    }
                    con.Close();
                }
                RepeterData();
            }
        }
        public void RepeterData()
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            cmd = new SqlCommand("Select * from Repeater Order By Header", con);
            DataSet ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            VertoRepeater.DataSource = ds;
            VertoRepeater.DataBind();
            con.Close();
        }
    }
}