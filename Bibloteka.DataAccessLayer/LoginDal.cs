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
                    const string sql = "EXEC usp_GetUserStafDetails @id";
                    var param = new {id = dt.Rows[0][0]};
                    perdoruesi = con.Query<Perdoruesi, Stafi, Roli, Perdoruesi>(sql,
                            (useri, stafi, roli) =>
                            {
                                useri.Stafi = stafi;
                                useri.Roli = roli;
                                return useri;
                            }, param, splitOn: "StafiID,Emertimi")
                        .FirstOrDefault();
                }
                return perdoruesi;
            }
        }
    }
}
