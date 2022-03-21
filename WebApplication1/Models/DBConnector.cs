using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace WebApplication1.Models
{
    public class DBConnector
    {
        SqlConnection ConnectionString = new("Data Source = LENOVO\\SQLEXPRESS;Initial Catalog=TRIMMS;Integrated Security=True;");
        //private SqlConnection? SqlConn = null;

        public SqlConnection GetConnection
        {
            get { return ConnectionString; }
            set { ConnectionString = value; }
        }

        //public DBConnector()
        //{
        //    SqlConnection ConnectionString = new("Data Source = LENOVO\\SQLEXPRESS;Initial Catalog=TRIMMS;Integrated Security=True;");
        //    //string ConnectionString = ConfigurationManager.ConnectionStrings["DataBase"].ConnectionString;
        //    //SqlConn = new SqlConnection(ConnectionString);
        //}
    }
}
