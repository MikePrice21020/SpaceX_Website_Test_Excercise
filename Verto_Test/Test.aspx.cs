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
    public partial class _Test : Page
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Michael\\source\\repos\\Verto_Test\\Verto_Test\\App_Data\\VertoData.mdf;Integrated Security=True");
        //static string constr = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\VertoData.mdf;Integrated Security=True;User Instance=True;";
        //public SqlConnection con = new SqlConnection(constr);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                RepeaterData();
            }
        }
        public void RepeaterData()
        {
            con.Open();
            cmd = new SqlCommand("Select * from Pagecontent Order By Id", con);
            DataSet ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            VertoRepeater.DataSource = ds;
            VertoRepeater.DataBind();
        }
    }
}