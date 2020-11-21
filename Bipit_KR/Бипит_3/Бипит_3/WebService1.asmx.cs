using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;

namespace Бипит_3
{
    /// <summary>
    /// Сводное описание для WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        string connectionString = "Data Source=DESKTOP-JCI0L7D\\SQLEXPRESS2017;Initial Catalog=bipitKR;Integrated Security=True";

        [WebMethod]
        public string HelloWorld()
        {
            return "Привет всем!";
        }
        
        [WebMethod]
        public DataTable FillNaklodnie()
        {
            var query = "SELECT Naklodnie.ID_NAKLODNIE as 'Номер', Name_postavshik  as 'Поставщик',Cost_naklodnie as 'Сумма', FORMAT(Data_naklodnie,'dd.MM.yyyy') as 'Дата' " +
                        " FROM Postavshik, Naklodnie " +
                        " WHERE Postavshik.ID_POSTAVSHIK = Naklodnie.ID_postavshik" ;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            dt.TableName = "Naklodnie";
                            sda.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }

        [WebMethod]
        public DataTable FillPostavshikt()
        {
            string query = "SELECT ID_POSTAVSHIK as 'Код поставщика', Name_postavshik  as 'Поставщик' FROM Postavshik";
            using (SqlConnection path = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        command.Connection = path;
                        sda.SelectCommand = command;
                        using (DataTable dt = new DataTable())
                        {
                            dt.TableName = "Postavshik";
                            sda.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
        }
        


        [WebMethod]
        public void InsertNaklodnie(string ID_POSTAVSHIK, string Cost_naklodnie, string Data_naklodnie)
        {
            var query = $"INSERT INTO Naklodnie VALUES ({ID_POSTAVSHIK}, '{Cost_naklodnie}', '{Data_naklodnie}')";
            var connect = new SqlConnection(connectionString);
            connect.Open();
            SqlCommand command = connect.CreateCommand();
            command.CommandText = query;
            command.ExecuteNonQuery();
            connect.Close();
        }

        [WebMethod]
        public void InsertPostavshik(string Name_postavshik)
        {
            var query = $"INSERT INTO Postavshik VALUES ('{Name_postavshik}')";
            var connect = new SqlConnection(connectionString);
            connect.Open();
            SqlCommand command = connect.CreateCommand();
            command.CommandText = query;
            command.ExecuteNonQuery();
            connect.Close();
        }

    }
}
