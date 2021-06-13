using Bibloteka.BusinessObjects;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteka.DataAccessLayer
{
    public class RoliDal
    {
        public List<Roli> GetRoli()
        {
            try
            {
                using (var con = DataAccessLayer.AppConnection())
                {
                    var list = con.Query<Roli>("usp_GetRolin", commandType: CommandType.StoredProcedure).ToList();
                    return list;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public int GetRoliById(string emertimi)
        {
            try
            {
                var sql = @"EXEC usp_GetRoliId @emri";
                using (var con = DataAccessLayer.AppConnection())
                    return con.Query<int>(sql, new { emri = emertimi }).FirstOrDefault();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public string GetNameById(int id)
        {
            try
            {
                const string sql = @"EXEC usp_GetRoliNameById @id";
                using (var con = DataAccessLayer.AppConnection())
                    return con.Query<string>(sql, new { id }).FirstOrDefault();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }

}
