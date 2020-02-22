﻿using System;
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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                string constr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\VertoData.mdf;Integrated Security=True";
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
                        con.Close();
                    }

                    using (SqlCommand cmd = new SqlCommand("SELECT Id, Header, ImgPath FROM Orbit WHERE Id = 1"))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        con.Open();
                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            sdr.Read();
                            orbit2_Header.Text = sdr["Header"].ToString();
                            orbit2_ImgPath.Text = sdr["ImgPath"].ToString();
                        }
                        con.Close();
                    }

                    using (SqlCommand cmd = new SqlCommand("SELECT Id, Header, ImgPath FROM Orbit WHERE Id = 2"))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        con.Open();
                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            sdr.Read();
                            orbit3_Header.Text = sdr["Header"].ToString();
                            orbit3_ImgPath.Text = sdr["ImgPath"].ToString();
                        }
                        con.Close();
                    }

                    using (SqlCommand cmd = new SqlCommand("SELECT Id, Header, ImgPath FROM Orbit WHERE Id = 3"))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        con.Open();
                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            sdr.Read();
                            orbit4_Header.Text = sdr["Header"].ToString();
                            orbit4_ImgPath.Text = sdr["ImgPath"].ToString();
                        }
                        con.Close();
                    }



                    //Load Page Content
                    using (SqlCommand cmd = new SqlCommand("SELECT Id, Header, ImgPath, Content FROM PageContent WHERE Id = 0"))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        con.Open();
                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            sdr.Read();
                            product_Header.Text = sdr["Header"].ToString();
                            product_ImgPath.Text = sdr["ImgPath"].ToString();
                            product_Content.Text = sdr["Content"].ToString();
                        }
                        con.Close();
                    }
                    using (SqlCommand cmd = new SqlCommand("SELECT Id, Header, ImgPath, Content FROM PageContent WHERE Id = 1"))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        con.Open();
                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            sdr.Read();
                            event_Header.Text = sdr["Header"].ToString();
                            event_ImgPath.Text = sdr["ImgPath"].ToString();
                            event_Content.Text = sdr["Content"].ToString();
                        }
                        con.Close();
                    }
                    using (SqlCommand cmd = new SqlCommand("SELECT Id, Header, ImgPath, Content FROM PageContent WHERE Id = 2"))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        con.Open();
                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            sdr.Read();
                            news_Header.Text = sdr["Header"].ToString();
                            news_ImgPath.Text = sdr["ImgPath"].ToString();
                            news_Content.Text = sdr["Content"].ToString();
                        }
                        con.Close();
                    }
                    using (SqlCommand cmd = new SqlCommand("SELECT Id, Header, ImgPath, Content FROM PageContent WHERE Id = 3"))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        con.Open();
                        using (SqlDataReader sdr = cmd.ExecuteReader())
                        {
                            sdr.Read();
                            gallery_Header.Text = sdr["Header"].ToString();
                            gallery_ImgPath.Text = sdr["ImgPath"].ToString();
                            gallery_Content.Text = sdr["Content"].ToString();
                        }
                        con.Close();
                    }
                }
            }
        }
    }
}