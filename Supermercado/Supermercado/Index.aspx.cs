using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Supermercado
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnForm1_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm1.aspx");
        }

        protected void btnForm2_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm2.aspx");
        }

        protected void btnForm3_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm3.aspx");
        }

        protected void btnForm4_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm4.aspx");
        }
    }
}