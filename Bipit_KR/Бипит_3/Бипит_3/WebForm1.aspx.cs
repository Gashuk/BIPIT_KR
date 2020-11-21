using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Бипит_3
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            ScriptManager.ScriptResourceMapping.AddDefinition("jquery", new ScriptResourceDefinition
            {
                Path = "~/Content/Js/jquery-3.2.1.min.js",
            });

            var s = new ServiceReference1.WebService1SoapClient();
            GridView2.DataSource = s.FillPostavshikt();
            GridView2.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = TextBox1.Text;
            var s = new ServiceReference1.WebService1SoapClient();
            s.InsertPostavshik(name);
            Response.Redirect("WebForm1.aspx");
        }
    }
}