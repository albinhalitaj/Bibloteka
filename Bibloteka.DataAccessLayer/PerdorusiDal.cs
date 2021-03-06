using Bibloteka.BusinessObjects;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteka.DataAccessLayer
{
    public class PerdorusiDal
    {
        public void InsertPerdoruesi(Perdoruesi perdoruesi)
        {
            try
            {
                using (var con = DataAccessLayer.AppConnection())
                {
                    var cmd = new SqlCommand("usp_InsertPerdoruesi", con) { CommandType = CommandType.StoredProcedure };
                    cmd.Parameters.AddWithValue("@stafiId", perdoruesi.StafiId);
                    cmd.Parameters.AddWithValue("@roliId", perdoruesi.RoliId);
                    cmd.Parameters.AddWithValue("@username", perdoruesi.Username);
                    cmd.Parameters.AddWithValue("@password", perdoruesi.Password);
                    cmd.Parameters.AddWithValue("@statusi", perdoruesi.Statusi);
                    cmd.Parameters.AddWithValue("@insertBy", perdoruesi.InsertBy);
                    cmd.Parameters.AddWithValue("@insertDate", perdoruesi.InsertDate);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }


        public void UpdatePerdoruesi(string id, Perdoruesi perdoruesi)
        {
            try
            {
                using (var con = DataAccessLayer.AppConnection())
                {
                    var cmd = new SqlCommand("usp_InsertPerdoruesi", con) { CommandType = CommandType.StoredProcedure };
                    cmd.Parameters.AddWithValue("@stafiId", perdoruesi.StafiId);
                    cmd.Parameters.AddWithValue("@roliId", perdoruesi.RoliId);
                    cmd.Parameters.AddWithValue("@username", perdoruesi.Username);
                    cmd.Parameters.AddWithValue("@password", perdoruesi.Password);
                    cmd.Parameters.AddWithValue("@statusi", perdoruesi.Statusi);
                    cmd.Parameters.AddWithValue("@insertBy", perdoruesi.InsertBy);
                    cmd.Parameters.AddWithValue("@insertDate", perdoruesi.InsertDate);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }


        public Perdoruesi GetPerdoruesiById(string id)
        {
            try
            {
                var perdoruesi = new Perdoruesi();
                using (var con = DataAccessLayer.AppConnection())
                {
                    var dt = new DataTable();
                    var cmd = new SqlCommand("usp_GetPerdoruesiById", con) { CommandType = CommandType.StoredProcedure };
                    cmd.Parameters.AddWithValue("@id",id);
                    var sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    return perdoruesi;
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
