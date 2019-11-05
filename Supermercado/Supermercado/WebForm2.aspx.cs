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
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        public void mostrarLista()
        {
            SqlConnection conex = conexion.obtenerConexion();
            SqlCommand comand = new SqlCommand("po_mostrarLista", conex);
            comand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(comand);
            DataSet set = new DataSet();
            adapter.Fill(set);
            ddlDatos.DataSource = set;
            ddlDatos.DataTextField = "NomCat";
            ddlDatos.DataBind();

        }

        public void mostrarTabla()
        {
            SqlConnection conex = conexion.obtenerConexion();
            SqlCommand comando = new SqlCommand("po_mostrarTabla", conex);
            comando.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataSet data = new DataSet();
            adapter.Fill(data);
            gvDatos.DataSource = data;
            gvDatos.DataBind();
        }

        protected void btnCargar_Click(object sender, EventArgs e)
        {
            mostrarLista();
            mostrarTabla();
        }

        protected void btnGenerar_Click(object sender, EventArgs e)
        {
            DataSet set = new DataSet();
            set.ReadXml(Server.MapPath("Categoria.xml"));
            ddlDatos.DataSource = set;
            ddlDatos.DataTextField = "NomCat";
            ddlDatos.DataBind();
            dynamic categoria = ddlDatos.DataSource;
            dynamic producto = gvDatos.DataSource;

            Session["Archivo"] = JsonConvert.SerializeObject(categoria);

            File.WriteAllText(Server.MapPath("Categoria.json"), "[" + Session["Archivo"].ToString() + "]");
            File.WriteAllText(Server.MapPath("Producto.json"), "[" + Session["Archivo"].ToString() + "]");
            Response.Write("<script>alert('Archivos JSON creado')</script>");
        }
    }
}