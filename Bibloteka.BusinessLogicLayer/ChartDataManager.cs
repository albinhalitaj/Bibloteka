using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibloteka.BusinessObjects;
using Bibloteka.DataAccessLayer;

namespace Bibloteka.BusinessLogicLayer
{
    public class ChartDataManager
    {
        private readonly ChartDataDal _chartData;
        public ChartDataManager() => _chartData = new ChartDataDal();
        public int[] GetHuazimetData() => _chartData.Huazimet();
        public int[] GetKthimetData() => _chartData.Kthimet();
        public List<PieViewModel> GetKategoriteData() => _chartData.Kategorite();
    }
}
