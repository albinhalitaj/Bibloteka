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
    public class LoginDal
    {
        public Perdoruesi Login(Perdoruesi user)
        {
            using (var con = DataAccessLayer.AppConnection())
            {
                var cmd = new SqlCommand("usp_Login", con) {CommandType = CommandType.StoredProcedure};
                cmd.Parameters.AddWithValue("@username", user.Username);
                cmd.Parameters.AddWithValue("@password", user.Password);
                var sda = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                sda.Fill(dt);
                Perdoruesi perdoruesi = null;
                if (dt.Rows.Count > 0)
                {
                    var param = new DynamicParameters();
                    string sql;
                    if (dt.Rows[0][3].Equals("public"))
                    {
                       sql = "EXEC usp_GetPublicDetails @username, @password";
                       param.Add("@username", user.Username);
                       param.Add("@password", user.Password);
                       perdoruesi = con.Query<Perdoruesi, Roli, Perdoruesi>(sql,
                           (useri, roli) =>
                           {
                               useri.Roli = roli;
                               return useri;
                           }, param,splitOn:"Emertimi").FirstOrDefault();
                    }
                    else
                    {
                        sql = "EXEC usp_GetUserStafDetails @id";
                        param.Add("@id",dt.Rows[0][0]);
                        perdoruesi = con.Query<Perdoruesi, Stafi, Roli, Perdoruesi>(sql,
                                (useri, stafi, roli) =>
                                {
                                    useri.Stafi = stafi;
                                    useri.Roli = roli;
                                    return useri;
                                }, param, splitOn: "StafiID,Emertimi")
                            .FirstOrDefault();
                    }
                }
                return perdoruesi;
            }
        }
    }
}
