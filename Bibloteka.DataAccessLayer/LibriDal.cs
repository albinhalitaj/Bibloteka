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
    public class LibriDal
    {
       // INSERT LIBER
       public void InsertLiber(Libri libri)
       {
           try
           {
               using (var con = DataAccessLayer.AppConnection())
               {
                   var cmd = new SqlCommand("usp_InsertLiber", con) {CommandType = CommandType.StoredProcedure};
                   cmd.Parameters.AddWithValue("@titulli", libri.Titulli);
                   cmd.Parameters.AddWithValue("@autori", libri.Autori);
                   cmd.Parameters.AddWithValue("@botuesi", libri.Botuesi);
                   cmd.Parameters.AddWithValue("@gjuhaId", libri.GjuhaId);
                   cmd.Parameters.AddWithValue("@tipiId", libri.TipiId);
                   cmd.Parameters.AddWithValue("@kategoriaId", libri.KategoriaId);
                   cmd.Parameters.AddWithValue("@isbn", libri.Isbn);
                   cmd.Parameters.AddWithValue("@editioni", libri.Editioni);
                   cmd.Parameters.AddWithValue("@numriKopjeve", libri.NumriKopjeve);
                   cmd.Parameters.AddWithValue("@statusi", libri.Statusi);
                   cmd.Parameters.AddWithValue("@insertBy", libri.InsertBy);
                   cmd.Parameters.AddWithValue("@insertDate", libri.InsertDate);
                   cmd.ExecuteNonQuery();
               }
           }
           catch (Exception e)
           {
               Console.WriteLine(e);
               throw;
           }
       }

       // UPDATE LIBER 
       public void UpdateLiber(string id, Libri libri)
       {
           try
           {
               using (var con = DataAccessLayer.AppConnection())
               {
                   var cmd = new SqlCommand("usp_UpdateLiber", con) {CommandType = CommandType.StoredProcedure};
                   cmd.Parameters.AddWithValue("@libriId", id);
                   cmd.Parameters.AddWithValue("@titulli", libri.Titulli);
                   cmd.Parameters.AddWithValue("@autori", libri.Autori);
                   cmd.Parameters.AddWithValue("@botuesi", libri.Botuesi);
                   cmd.Parameters.AddWithValue("@gjuhaId", libri.GjuhaId);
                   cmd.Parameters.AddWithValue("@tipiId", libri.TipiId);
                   cmd.Parameters.AddWithValue("@kategoriaId", libri.KategoriaId);
                   cmd.Parameters.AddWithValue("@isbn", libri.Isbn);
                   cmd.Parameters.AddWithValue("@editioni", libri.Editioni);
                   cmd.Parameters.AddWithValue("@numriKopjeve", libri.NumriKopjeve);
                   cmd.Parameters.AddWithValue("@statusi", libri.Statusi);
                   cmd.Parameters.AddWithValue("@lub", libri.Lub);
                   cmd.Parameters.AddWithValue("@lun", libri.Lun);
                   cmd.Parameters.AddWithValue("@lud", libri.Lud);
                   cmd.ExecuteNonQuery();
               }
           }
           catch (Exception e)
           {
               Console.WriteLine(e);
               throw;
           }
       }

       // DELETE LIBER 
       public void DeleteLiber(string id)
       {
           try
           {
               using (var con = DataAccessLayer.AppConnection())
               {
                   var cmd = new SqlCommand("usp_DeleteLiber", con) {CommandType = CommandType.StoredProcedure};
                   cmd.Parameters.AddWithValue("@libriId", id);
                   cmd.ExecuteNonQuery();
               }
           }
           catch (Exception e)
           {
               Console.WriteLine(e);
               throw;
           }
       }


       // GET ALL LIBRAT 
       public DataTable GetAllLibrat()
       {
           try
           {
               using (var con = DataAccessLayer.AppConnection())
               {
                   var dt = new DataTable();
                   var cmd = new SqlCommand("[usp_GetAllLibrat]", con) {CommandType = CommandType.StoredProcedure};
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

       // GET LIBER BY ID 
       public Libri GetLiberById(string id)
       {
           try
           {
               using (var con = DataAccessLayer.AppConnection())
               {
                   var param = new
                   {
                       libriId = id
                   };
                   var libriDetalet = con.Query<Libri>("EXEC usp_GetLiberById @libriId", param).FirstOrDefault();
                   return libriDetalet;
               }
           }
           catch (Exception e)
           {
               Console.WriteLine(e);
               throw;
           }
       }

       // GET TOTAL LIBRA
       public int GetTotal()
       {
           try
           {
               using (var con = DataAccessLayer.AppConnection())
               {
                   var total = con.Query<int>("usp_GetTotalLiber").FirstOrDefault();
                   return total;
               }
           }
           catch (Exception e)
           {
               Console.WriteLine(e);
               throw;
           }
       }

       // SEARCH LIBRA 
       public DataTable SearchLibra(string query)
       {
           try
           {
               using (var con = DataAccessLayer.AppConnection())
               {
                   var dt = new DataTable();
                   var cmd = new SqlCommand("usp_SearchLiber", con) {CommandType = CommandType.StoredProcedure};
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
    }
}
