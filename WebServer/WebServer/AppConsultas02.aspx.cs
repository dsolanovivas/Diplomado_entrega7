using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebServer
{
    public partial class AppConsultas02 : System.Web.UI.Page
    {
        private string cadenas;
        string sCommand;

        protected void Page_Load(object sender, EventArgs e)
        {
            cadenas = @"Data Source=(LocalDb)\v11.0;AttachDbFilename=c:\users\lab104bpc17\documents\visual studio 2012\Projects\WebServer\WebServer\App_Data\aspnet-WebServer-20150423185107.mdf;Initial Catalog=aspnet-WebServer-20150423185107;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cadenas);
            sCommand="SELECT * FROM USUARIOS";
            SqlDataAdapter da = new SqlDataAdapter(sCommand, cn);
            DataTable datetable = new DataTable();
            cn.Open();

            int recordsAffeted = da.Fill(datetable);
            GridView1.DataSource = datetable;
            GridView1.DataBind();
            cn.Close();
        }
    }
}