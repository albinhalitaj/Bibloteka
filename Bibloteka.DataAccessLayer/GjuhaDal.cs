using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibloteka.BusinessObjects;
using Dapper;

namespace Bibloteka.DataAccessLayer
{
    public class GjuhaDal
    {
        public List<Gjuha> GetLanguages()
        {
            try
            {
                using (var con = DataAccessLayer.AppConnection())
                {
                    var list = con.Query<Gjuha>("usp_GetGjuhet", commandType: CommandType.StoredProcedure).ToList();
                    return list;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public int GetGjuhaById(string emertimi)
        {
            try
            {
                var sql = @"EXEC usp_GetGjuhaId @emri";
                using (var con = DataAccessLayer.AppConnection())
                    return con.Query<int>(sql, new {emri = emertimi}).FirstOrDefault();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
