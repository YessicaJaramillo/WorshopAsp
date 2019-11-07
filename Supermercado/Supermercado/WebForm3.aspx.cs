using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using Newtonsoft.Json;

namespace Supermercado
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                mostrarLista();
                mostrarTabla();
            }
            

        }
        public void mostrarLista()
        {

            SqlConnection conex = conexion.obtenerConexion();
            SqlCommand comand = new SqlCommand("po_mostrarLista", conex);
            comand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(comand);
            DataSet set = new DataSet();
            adapter.Fill(set);
            ddlInformacion.DataSource = set;
            ddlInformacion.DataTextField = "NomCat";
            ddlInformacion.DataValueField = "CodCat";
            ddlInformacion.DataBind();

        }

        public void mostrarTabla()
        {
            SqlConnection conex = conexion.obtenerConexion();
            SqlCommand comando = new SqlCommand("po_mostrarTabla", conex);
            comando.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataSet data = new DataSet();
            adapter.Fill(data);
            gvInformacion.DataSource = data;
            gvInformacion.DataBind();
      
        }

        protected void ddlInformacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            int campo = Convert.ToInt32( ddlInformacion.SelectedValue);
            SqlConnection conex = conexion.obtenerConexion();
            SqlCommand comando = new SqlCommand("pa_consulta", conex);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add("@consulta",SqlDbType.Int).Value=campo;
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataSet set = new DataSet();
            adapter.Fill(set);
            gvInformacion.DataSource = set;
            gvInformacion.DataBind();
        }
    }
}