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
    public class HuazimetDal
    {

        // Huazo Liber
        public void HuazoLiber(Huazimi huazimi)
        {
            try
            {
                using (var con = DataAccessLayer.AppConnection())
                {
                    var cmd = new SqlCommand("usp_ShtoHuazim",con) {CommandType = CommandType.StoredProcedure};
                    cmd.Parameters.AddWithValue("libriId", huazimi.LibriId);
                    cmd.Parameters.AddWithValue("klientiId", huazimi.KlientiId);
                    cmd.Parameters.AddWithValue("sasia", huazimi.NumriKopjeve);
                    cmd.Parameters.AddWithValue("dataHuazimit", huazimi.DataHuazimi);
                    cmd.Parameters.AddWithValue("dataKthimit", huazimi.DataKthimit);
                    cmd.Parameters.AddWithValue("statusi", huazimi.Statusi);
                    cmd.Parameters.AddWithValue("pershkrimi", huazimi.Pershkrimi);
                    cmd.Parameters.AddWithValue("insertBy", huazimi.InsertBy);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void ShtoAktivitetin(Aktiviteti act)
        {
            try
            {
                using (var con = DataAccessLayer.AppConnection())
                {
                    var cmd = new SqlCommand("usp_InsertAktivitet", con) {CommandType = CommandType.StoredProcedure};
                    cmd.Parameters.AddWithValue("klientiId", act.KlientiId);
                    cmd.Parameters.AddWithValue("libriId", act.LibriId);
                    cmd.Parameters.AddWithValue("date", act.Data);
                    cmd.Parameters.AddWithValue("tipi", act.Tipi);
                    cmd.Parameters.AddWithValue("insertBy", act.InsertBy);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public List<Klienti> GetKlientet()
        {
            try
            {
                var klientet = new List<Klienti>();
                using (var con = DataAccessLayer.AppConnection())
                {
                    var dt = new DataTable();
                    var cmd = new SqlCommand("usp_GetAllKlients", con);
                    var sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        klientet.AddRange(from DataRow row in dt.Rows 
                            select new Klienti
                            {
                                KlientiId = Convert.ToString(row[0]), 
                                Emri = Convert.ToString(row[1]), 
                                Mbiemri = Convert.ToString(row[2])
                            });
                    }
                }
                return klientet;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public List<Libri> GetLibrat()
        {
            try
            {
                var librat = new List<Libri>();
                using (var con = DataAccessLayer.AppConnection())
                {
                    var dt = new DataTable();
                    var cmd = new SqlCommand("usp_GetAllLibratPerHuazim", con);
                    var sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        librat.AddRange(from DataRow row in dt.Rows
                            select new Libri
                            {
                                LibriId = Convert.ToString(row[0]),
                                Titulli = Convert.ToString(row[1])
                            });
                    }
                }
                return librat;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public DataTable LoadHuazimetMuajtiAktual()
        {
            try
            {
                using (var con = DataAccessLayer.AppConnection())
                {
                    var dt = new DataTable();
                    var cmd = new SqlCommand("usp_GetHuazimetMuajitAktual", con) {CommandType = CommandType.StoredProcedure};
                    var sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    return dt;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public DataTable FiltroHuazimet(DateTime nga, DateTime deri)
        {
            try
            {
                using (var con = DataAccessLayer.AppConnection())
                {
                    var dt = new DataTable();
                    var cmd = new SqlCommand("usp_FiltroHuazimet", con) {CommandType = CommandType.StoredProcedure};
                    cmd.Parameters.AddWithValue("ngaData", nga);
                    cmd.Parameters.AddWithValue("deriData", deri);
                    var sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    return dt;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public DataTable Kerko(string query)
        {
            try
            {
                using (var con = DataAccessLayer.AppConnection())
                {
                    var dt = new DataTable();
                    var cmd = new SqlCommand("usp_KerkoLibra", con) {CommandType = CommandType.StoredProcedure};
                    cmd.Parameters.AddWithValue("query", query);
                    var sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    return dt;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public Huazimi GetHuazimById(int id)
        {
            try
            {
                var huazimi = new Huazimi();
                using (var con = DataAccessLayer.AppConnection())
                {
                    var dt = new DataTable();
                    var cmd = new SqlCommand("usp_GetHuazimiById", con) {CommandType = CommandType.StoredProcedure};
                    cmd.Parameters.AddWithValue("id", id);
                    var sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            huazimi = new Huazimi
                            {
                                HuazimiId = Convert.ToInt32(row[0]),
                                LibriId = Convert.ToString(row[1]),
                                KlientiId = Convert.ToString(row[2]),
                                NumriKopjeve = Convert.ToInt32(row[3]),
                                DataHuazimi = Convert.ToDateTime(row[4]),
                                DataKthimit = Convert.ToDateTime(row[5]),
                                Statusi = Convert.ToBoolean(row[6])
                            };
                        }
                    }
                    return huazimi;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public int GetHuazimetTotal()
        {
            int huazimet;
            using (var con = DataAccessLayer.AppConnection())
                huazimet = con.Query<int>("exec usp_GetHuazimetTotal").FirstOrDefault();
            return huazimet;
        }

    }
}
