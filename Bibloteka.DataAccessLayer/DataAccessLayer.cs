using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Bibloteka.DataAccessLayer
{
    public static class DataAccessLayer
    {
        public static SqlConnection AppConnection()
        {
            var conString = ConfigurationManager.ConnectionStrings["albikCon"].ConnectionString;
            //var conString = ConfigurationManager.ConnectionStrings["endritCon"].ConnectionString;
            //var conString = ConfigurationManager.ConnectionStrings["fatlindCon"].ConnectionString;
            var con = new SqlConnection(conString);
            if (con.State != ConnectionState.Open) con.Open();
            return con;
        }
    }
}