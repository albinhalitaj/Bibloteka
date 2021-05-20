using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibloteka.BusinessObjects
{
    public class Stafi
    {
        public int StafiId { get; set; }

        public string Emri { get; set; }

        public string Mbiemri { get; set; }

        public DateTime Datelindja { get; set; }

        public string Gjinia { get; set; }

        public string NrPersonal { get; set; }

        public string NrKontaktues { get; set; }

        public string Adresa { get; set; }

        public string Qyteti { get; set; }

        public string Shteti { get; set; }

        public string KodiPostal { get; set; }

        public string Emaili { get; set; }

        public int InsertBy { get; set; }

        public DateTime? InsertDate { get; set; }

        public int? Lub { get; set; }

        public int? Lun { get; set; }

        public DateTime? Lud { get; set; }
        
    }
}
