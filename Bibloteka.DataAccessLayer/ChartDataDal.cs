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
    public class ChartDataDal
    {
        public int[] Huazimet()
        {
            try
            {
                using (var con = DataAccessLayer.AppConnection())
                {
                    var dt = new DataTable();
                    var cmd = new SqlCommand("usp_GetHuazimetData", con) {CommandType = CommandType.StoredProcedure};
                    var sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    var huazimet = new List<ChartViewModel>();
                    var huazimetData = new int[12];
                    if (dt.Rows.Count > 0)
                    {
                        huazimet.AddRange(
                            from DataRow row in dt.Rows
                            select new ChartViewModel 
                                {Muaji = Convert.ToInt32(row[0]),
                                    Numri = Convert.ToInt32(row[1])});
                    }

                    foreach (var stat in huazimet)
                        for (var i = 0; i < 12; i++)
                            if ((Convert.ToInt32(stat.Muaji) - 1) == i)
                                huazimetData[i] = stat.Numri;
                    return huazimetData;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public int[] Kthimet()
        {
            try
            {
                using (var con = DataAccessLayer.AppConnection())
                {
                    var dt = new DataTable();
                    var cmd = new SqlCommand("usp_GetKthimetData", con) { CommandType = CommandType.StoredProcedure };
                    var sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    var kthimet = new List<ChartViewModel>();
                    var kthimetData = new int[12];
                    if (dt.Rows.Count > 0)
                    {
                        kthimet.AddRange(
                            from DataRow row in dt.Rows
                            select new ChartViewModel
                            {
                                Muaji = Convert.ToInt32(row[0]),
                                Numri = Convert.ToInt32(row[1])
                            });
                    }

                    foreach (var stat in kthimet)
                        for (var i = 0; i < 12; i++)
                            if ((Convert.ToInt32(stat.Muaji) - 1) == i)
                                kthimetData[i] = stat.Numri;
                    return kthimetData;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public List<PieViewModel> Kategorite()
        {
            try
            {
                using (var con = DataAccessLayer.AppConnection())
                {
                    var dt = new DataTable();
                    var cmd = new SqlCommand("usp_GetKategoriteData", con) {CommandType = CommandType.StoredProcedure};
                    var sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    var kategorite = new List<PieViewModel>();
                    if (dt.Rows.Count > 0)
                    {
                        kategorite.AddRange(from DataRow row in dt.Rows
                            select new PieViewModel
                            {
                                Emertimi = Convert.ToString(row[0]),
                                Librat = Convert.ToInt32(row[1])
                            });
                    }
                    return kategorite;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }

    public class ChartViewModel
    {
        public int Muaji { get; set; }
        public int Numri { get; set; }
    }
}
