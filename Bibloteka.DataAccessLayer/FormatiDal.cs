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
    public class FormatiDal
    {
        public List<Formati> GetFormats()
        {
            try
            {
                using (var con = DataAccessLayer.AppConnection())
                {
                    var listFormats = con.Query<Formati>("usp_GetFormats", commandType: CommandType.StoredProcedure).ToList();
                    return listFormats;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public int GetFormatiId(string emri)
        {
            try
            {
                using (var con = DataAccessLayer.AppConnection())
                {
                    const string sql = @"EXEC usp_GetFormatiId @emertimi";
                    return con.Query<int>(sql, new {emertimi = emri}).FirstOrDefault();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
