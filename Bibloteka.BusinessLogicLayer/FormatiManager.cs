using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bibloteka.BusinessObjects;
using Bibloteka.DataAccessLayer;

namespace Bibloteka.BusinessLogicLayer
{
    public class FormatiManager
    {
        private readonly FormatiDal _formatiDal;
        public FormatiManager()
        {
            _formatiDal = new FormatiDal();
        }

        public List<Formati> Load() => _formatiDal.GetFormats();
    }
}
