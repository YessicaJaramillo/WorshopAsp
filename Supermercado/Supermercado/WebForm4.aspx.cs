using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.IO;
using Newtonsoft.Json;

namespace Supermercado
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           /* string categoria = File.ReadAllText(Server.MapPath("Categoria.json"));
            DataTable table = (DataTable)JsonConvert.DeserializeObject(categoria, typeof(DataTable));
            ddlCategoria.DataSource = table;
            ddlCategoria.DataTextField = "NomCat";
            ddlCategoria.DataBind(); */

        }
    }
}