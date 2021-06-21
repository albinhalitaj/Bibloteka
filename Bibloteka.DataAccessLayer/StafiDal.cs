using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibloteka.BusinessObjects;
using Dapper;
using System.Data.SqlClient;
using System.Data;

namespace Bibloteka.DataAccessLayer
{
     public class StafiDal
    {
        public void InsertStafi(Stafi stafi,Perdoruesi perdoruesi,int roliID)
        {
            try
            {
                using (var con = DataAccessLayer.AppConnection())
                {
                    var cmd = new SqlCommand("usp_InsertStaf", con) { CommandType = CommandType.StoredProcedure };
                    cmd.Parameters.AddWithValue("@emri", stafi.Emri);
                    cmd.Parameters.AddWithValue("@mbiemri", stafi.Mbiemri);
                    cmd.Parameters.AddWithValue("@datalindjes", stafi.Datelindja);
                    cmd.Parameters.AddWithValue("@gjinia", stafi.Gjinia);
                    cmd.Parameters.AddWithValue("@nrPersonal", stafi.NrPersonal);
                    cmd.Parameters.AddWithValue("@nrKontaktues", stafi.NrKontaktues);
                    cmd.Parameters.AddWithValue("@kualifikimiID", stafi.KualifikimiID);
                    cmd.Parameters.AddWithValue("@adresa", stafi.Adresa);
                    cmd.Parameters.AddWithValue("@shteti", stafi.Shteti);
                    cmd.Parameters.AddWithValue("@qyteti", stafi.Qyteti);
                    cmd.Parameters.AddWithValue("@kodiPostal", stafi.KodiPostal);
                    cmd.Parameters.AddWithValue("@emaili", stafi.Emaili);
                    cmd.Parameters.AddWithValue("@insertBy", stafi.InsertBy);
                    cmd.Parameters.AddWithValue("@insertDate", stafi.InsertDate);
                    cmd.Parameters.AddWithValue("@username", perdoruesi.Username);
                    cmd.Parameters.AddWithValue("@password", perdoruesi.Password);
                    cmd.Parameters.AddWithValue("@roliID", roliID);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }


        public void UpdateStafin(string id, Stafi stafi,Perdoruesi perdoruesi, int roliID)
        {
            try
            {
                using (var con = DataAccessLayer.AppConnection())
                {
                    var cmd = new SqlCommand("usp_UpdateStaf", con) { CommandType = CommandType.StoredProcedure };
                    cmd.Parameters.AddWithValue("@stafiid", id);
                    cmd.Parameters.AddWithValue("@emri", stafi.Emri);
                    cmd.Parameters.AddWithValue("@mbiemri", stafi.Mbiemri);
                    cmd.Parameters.AddWithValue("@datalindjes", stafi.Datelindja);
                    cmd.Parameters.AddWithValue("@gjinia", stafi.Gjinia);
                    cmd.Parameters.AddWithValue("@nrPersonal", stafi.NrPersonal);
                    cmd.Parameters.AddWithValue("@nrKontaktues", stafi.NrKontaktues);
                    cmd.Parameters.AddWithValue("@kualifikimiID", stafi.KualifikimiID);
                    cmd.Parameters.AddWithValue("@adresa", stafi.Adresa);
                    cmd.Parameters.AddWithValue("@shteti", stafi.Shteti);
                    cmd.Parameters.AddWithValue("@qyteti", stafi.Qyteti);
                    cmd.Parameters.AddWithValue("@kodiPostal", stafi.KodiPostal);
                    cmd.Parameters.AddWithValue("@emaili", stafi.Emaili);
                    cmd.Parameters.AddWithValue("@username", perdoruesi.Username);
                    cmd.Parameters.AddWithValue("@password", perdoruesi.Password);
                    cmd.Parameters.AddWithValue("@roliID", roliID);
                    cmd.Parameters.AddWithValue("@lub", stafi.Lub);
                    cmd.Parameters.AddWithValue("@lun", stafi.Lun);
                    cmd.Parameters.AddWithValue("@lud", stafi.Lud);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public DataTable GetStafinById(string id)
        {
            using (var con = DataAccessLayer.AppConnection())
            {
                var dt = new DataTable();
                var cmd = new SqlCommand("usp_GetStafById", con) { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@id", id);
                var sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                return dt;
            }
        }
        public DataTable GetShtetiById(string id)
        {
            using (var con = DataAccessLayer.AppConnection())
            {
                var dt = new DataTable();
                var cmd = new SqlCommand("usp_GetShtetiById", con) { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@id", id);
                var sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                return dt;
            }
        }


        public DataTable SearchStafin(string query)
        {
            try
            {
                using (var con = DataAccessLayer.AppConnection())
                {
                    var dt = new DataTable();
                    var cmd = new SqlCommand("usp_SearchStafi", con) { CommandType = CommandType.StoredProcedure };
                    cmd.Parameters.AddWithValue("@query", query);
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

        public DataTable GetAllRolet()
        {
            try
            {
                using(var con = DataAccessLayer.AppConnection())
                {
                    var dt = new DataTable();
                    var cmd = new SqlCommand("usp_GetAllRolet", con) { CommandType = CommandType.StoredProcedure };
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

        public DataTable GetAllKualifikmet()
        {
            try
            {
                using (var con = DataAccessLayer.AppConnection())
                {
                    var dt = new DataTable();
                    var cmd = new SqlCommand("usp_GetAllKualifikimet", con) { CommandType = CommandType.StoredProcedure };
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
        public DataTable GetAllStafin()
        {
            try
            {
                using (var con = DataAccessLayer.AppConnection())
                {
                    var dt = new DataTable();
                    var cmd = new SqlCommand("usp_GetAllStaf", con) { CommandType = CommandType.StoredProcedure };
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

        public void DeleteStafin(string id)
        {
            try
            {
                using (var con = DataAccessLayer.AppConnection())
                {
                    var cmd = new SqlCommand("usp_DeleteStaf", con) { CommandType = CommandType.StoredProcedure };
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
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

