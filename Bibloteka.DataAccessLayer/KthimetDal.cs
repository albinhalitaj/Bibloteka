using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibloteka.BusinessObjects;
using Dapper;

namespace Bibloteka.DataAccessLayer
{
    public class KthimetDal
    {
        public Kthimi GetHuazimiById(int id)
        {
            try
            {
                using (var con = DataAccessLayer.AppConnection())
                {
                    var kthimiData = new Kthimi();
                    var dt = new DataTable();
                    var cmd = new SqlCommand("usp_GetKthimiById", con) {CommandType = CommandType.StoredProcedure};
                    cmd.Parameters.AddWithValue("id", id);
                    var sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            kthimiData = new Kthimi
                            {
                                HuazimiId = Convert.ToInt32(row[0]),
                                KlientiId = Convert.ToString(row[1]),
                                Klienti = Convert.ToString(row[2]),
                                LibriId = Convert.ToString(row[3]),
                                Libri = Convert.ToString(row[4]),
                                DataHuazimit = Convert.ToDateTime(row[5]),
                                DataKthimit = Convert.ToDateTime(row[6]),
                                Sasia = Convert.ToInt32(row[7]),
                                Pershkrimi = Convert.ToString(row[9])
                            };
                        }
                    }
                    return kthimiData;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void ShtoGjobe(Gjoba gjoba)
        {
            try
            {
                using (var con = DataAccessLayer.AppConnection())
                {
                    var cmd = new SqlCommand("usp_InsertGjobe", con) {CommandType = CommandType.StoredProcedure};
                    cmd.Parameters.AddWithValue("klientiId", gjoba.KlientiId);
                    cmd.Parameters.AddWithValue("shuma", gjoba.Shuma);
                    cmd.Parameters.AddWithValue("shumaPranuar", gjoba.ShumaPranuar);
                    cmd.Parameters.AddWithValue("insertBy", gjoba.InsertBy);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void KtheLibrin(string libriId,int id,int sasia)
        {
            try
            {
                using (var con = DataAccessLayer.AppConnection())
                {
                    var cmd = new SqlCommand("usp_KtheLiber", con) { CommandType = CommandType.StoredProcedure };
                    cmd.Parameters.AddWithValue("id",id);
                    cmd.Parameters.AddWithValue("sasia", sasia);
                    cmd.Parameters.AddWithValue("libriId", libriId);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public int GetTotalKthimet()
        {
            int kthimet;
            using (var con = DataAccessLayer.AppConnection())
                kthimet = con.Query<int>("exec usp_GetTotalKthimet").FirstOrDefault();
            return kthimet;
        }
    }
}
