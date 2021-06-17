using Bibloteka.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibloteka.DataAccessLayer;


namespace Bibloteka.BusinessLogicLayer
{
    public class PerdoruesiManager
    {
        public readonly PerdorusiDal PerdoruesiDal;
        public PerdoruesiManager() => PerdoruesiDal = new PerdorusiDal();
        public void Add(Perdoruesi perdoruesi) => PerdoruesiDal.InsertPerdoruesi(perdoruesi);
        public void Update(string id, Perdoruesi perdoruesi) => PerdoruesiDal.UpdatePerdoruesi(id, perdoruesi);
    }
}
