using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Bibloteka.DataAccessLayer
{
    public static class DataAccessLayer
    {
        public static string AppConnection() => ConfigurationManager.ConnectionStrings["albikCon"].ConnectionString;
    }
}