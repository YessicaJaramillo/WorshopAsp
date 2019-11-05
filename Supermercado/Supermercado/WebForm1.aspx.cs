using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using System.Web.Script.Serialization;

namespace Supermercado
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            
        }

        protected void btnCargar_Click(object sender, EventArgs e)
        {
            DataSet set = new DataSet();
            set.ReadXml(Server.MapPath("Categoria.xml"));
            ddlCategoria.DataSource = set;
            ddlCategoria.DataTextField = "NomCat";
            ddlCategoria.DataBind();


            DataSet data = new DataSet();
            data.ReadXml(Server.MapPath("Producto.xml"));
            gvProducto.DataSource = data.Tables[0];
            gvProducto.DataBind();


        }
    }
}