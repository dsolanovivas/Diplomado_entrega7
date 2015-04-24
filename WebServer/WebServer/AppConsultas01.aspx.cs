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
    public partial class AppConsultas01 : System.Web.UI.Page
    {
        private string cadenas;
        string sCommand;
        string nombre, apellido, correo;
        int edad;

        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void btningresar_Click(object sender, EventArgs e)
        {
            cadenas = @"Data Source=(LocalDb)\v11.0;AttachDbFilename=c:\users\lab104bpc17\documents\visual studio 2012\Projects\WebServer\WebServer\App_Data\aspnet-WebServer-20150423185107.mdf;Initial Catalog=aspnet-WebServer-20150423185107;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cadenas);
            //sCommand="SELECT * FROM USUARIOS";
            cn.Open();

            nombre = txtnom.Text;
            apellido = txtapellido.Text;
            correo = txtcorreo.Text;
            edad = int.Parse(txtedad.Text);

            sCommand = "Insert into usuarios(nombre,apellido,edad,correo) values " +
                " ('"+nombre+"','"+apellido+"',"+edad+",'"+correo+"') ";
            SqlDataAdapter da = new SqlDataAdapter(sCommand, cn);
            // DataTable datetable = new DataTable();
            SqlCommand comando = new SqlCommand(sCommand, cn);
            comando.ExecuteNonQuery();
            cn.Close();
        }
    }
}