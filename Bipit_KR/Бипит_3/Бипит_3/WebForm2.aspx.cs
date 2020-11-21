using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Бипит_3
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ScriptManager.ScriptResourceMapping.AddDefinition("jquery", new ScriptResourceDefinition
            {
                Path = "~/Content/Js/jquery-3.2.1.min.js",
            });

            ServiceReference1.WebService1SoapClient s = new ServiceReference1.WebService1SoapClient();
            GridView1.DataSource = s.FillNaklodnie();
            GridView1.DataBind();

            DropDownList1.DataSource = s.FillPostavshikt();
            DropDownList1.DataTextField = "Поставщик";
            DropDownList1.DataValueField = "Код поставщика";
            DropDownList1.DataBind();


        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            var s = new ServiceReference1.WebService1SoapClient();
            var ID_POSTAVSHIK = DropDownList1.Text;
            var Cost_naklodnie = dateEx.Text;
            var Data_naklodnie = dateEx0.Text;
            if (Data_naklodnie != "")
            {
                s.InsertNaklodnie(ID_POSTAVSHIK, Cost_naklodnie, Data_naklodnie);
                Response.Redirect("WebForm2.aspx");
            }

        }
        
    }
}