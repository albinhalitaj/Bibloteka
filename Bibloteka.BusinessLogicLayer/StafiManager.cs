using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibloteka.BusinessObjects;
using Bibloteka.DataAccessLayer;

namespace Bibloteka.BusinessLogicLayer
{
    public class StafiManager
    {
        private readonly StafiDal StafiDal;
        public StafiManager() => StafiDal = new StafiDal();
        public void Add(Stafi stafi,Perdoruesi perdoruesi) => StafiDal.InsertStafi(stafi,perdoruesi);
        public void Update(int id, Stafi stafi,Perdoruesi perdoruesi) => StafiDal.UpdateStafin(id,stafi,perdoruesi);
        public bool Remove(int id) => StafiDal.DeleteStafin(id);
        public DataTable Load() => StafiDal.GetAllStafin();
        public DataTable FindById(int id) => StafiDal.GetStafinById(id);

        public DataTable Search(string query) => StafiDal.SearchStafin(query);

        public DataTable GetRolet() => StafiDal.GetAllRolet();

        public DataTable GetKualifikimet() => StafiDal.GetAllKualifikmet();



    }
}
