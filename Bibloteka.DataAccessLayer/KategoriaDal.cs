using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Bibloteka.BusinessObjects;
using Dapper;

namespace Bibloteka.DataAccessLayer
{
    public class KategoriaDal
    {

        public void ShtoKategori(Kategoria kategoria)
        {
            try
            {
                using (var con = DataAccessLayer.AppConnection())
                {
                    var cmd = new SqlCommand("usp_InsertCategory", con) {CommandType = CommandType.StoredProcedure};
                    cmd.Parameters.AddWithValue("@emertimi", kategoria.Emertimi);
                    cmd.Parameters.AddWithValue("@pershkrimi", kategoria.Pershkrimi);
                    cmd.Parameters.AddWithValue("@insertBy", kategoria.InsertBy);
                    cmd.Parameters.AddWithValue("@insertDate", kategoria.InsertDate);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }


        public void EditoKategori(int id, Kategoria kategoria)
        {
            try
            {
                using (var con = DataAccessLayer.AppConnection())
                {
                    var cmd = new SqlCommand("usp_UpdateCategory", con) { CommandType = CommandType.StoredProcedure };
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@emertimi", kategoria.Emertimi);
                    cmd.Parameters.AddWithValue("@pershkrimi", kategoria.Pershkrimi);
                    cmd.Parameters.AddWithValue("@lub", kategoria.Lub);
                    cmd.Parameters.AddWithValue("@lun", kategoria.Lun);
                    cmd.Parameters.AddWithValue("@lud", kategoria.Lud);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void FshiKategori(int id)
        {
            try
            {
                using (var con = DataAccessLayer.AppConnection())
                {
                    var cmd = new SqlCommand("usp_DeleteCategory", con) { CommandType = CommandType.StoredProcedure };
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


        public DataTable GetCategoryById(int id)
        {
            try
            {
                using (var con = DataAccessLayer.AppConnection())
                {
                    var dt = new DataTable();
                    var cmd = new SqlCommand("usp_GetCategoryById", con) {CommandType = CommandType.StoredProcedure};
                    cmd.Parameters.AddWithValue("@id", id);
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

        public DataTable GetAllCategories()
        {
            try
            {
                using (var con = DataAccessLayer.AppConnection())
                {
                    var dt = new DataTable();
                    var cmd = new SqlCommand("usp_GetCategories", con) {CommandType = CommandType.StoredProcedure};
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

        public DataTable SearchCategories(string query)
        {
            try
            {
                using (var con = DataAccessLayer.AppConnection())
                {
                    var dt = new DataTable();
                    var cmd = new SqlCommand("usp_SearchCategories", con) { CommandType = CommandType.StoredProcedure };
                    cmd.Parameters.AddWithValue("@emertimi", query);
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

        public int Total()
        {
            int tot;
            using (var con = DataAccessLayer.AppConnection())
                tot = con.Query<int>("SELECT COUNT(*) FROM Kategoria").FirstOrDefault();
            return tot;
        }
    }
}
