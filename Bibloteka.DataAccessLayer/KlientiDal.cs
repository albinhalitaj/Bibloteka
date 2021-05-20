using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibloteka.BusinessObjects;

namespace Bibloteka.DataAccessLayer
{
    public class KlientiDal
    {
        public void ShtoKlient(Klienti klienti)
        {
            try
            {
                using (var con = DataAccessLayer.AppConnection())
                {
                    var cmd = new SqlCommand("usp_InsertKlient", con) {CommandType = CommandType.StoredProcedure};
                    cmd.Parameters.AddWithValue("@emri", klienti.Emri);
                    cmd.Parameters.AddWithValue("@mbiemri", klienti.Mbiemri);
                    cmd.Parameters.AddWithValue("@datalindjes", klienti.Datalindjes);
                    cmd.Parameters.AddWithValue("@gjinia", klienti.Gjinia);
                    cmd.Parameters.AddWithValue("@nrPersonal", klienti.NrPersonal);
                    cmd.Parameters.AddWithValue("@nrKontaktues", klienti.NrKontaktues);
                    cmd.Parameters.AddWithValue("@adresa", klienti.Adresa);
                    cmd.Parameters.AddWithValue("@shteti", klienti.Shteti);
                    cmd.Parameters.AddWithValue("@qyteti", klienti.Qyteti);
                    cmd.Parameters.AddWithValue("@kodiPostal", klienti.KodiPostal);
                    cmd.Parameters.AddWithValue("@emaili", klienti.Emaili);
                    cmd.Parameters.AddWithValue("@insertBy", klienti.InsertBy);
                    cmd.Parameters.AddWithValue("@insertDate", klienti.InsertDate);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }


        public void Ndrysho(int id, Klienti klienti)
        {

        }


        public DataTable GetAllKlients()
        {
            try
            {
                using (var con = DataAccessLayer.AppConnection())
                {
                    var dt = new DataTable();
                    var cmd = new SqlCommand("usp_GetAllKlients", con) {CommandType = CommandType.StoredProcedure};
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
    }
}
