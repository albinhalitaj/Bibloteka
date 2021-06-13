using System;

namespace Bibloteka.BusinessObjects
{
    public class Gjoba
    {
        public int GjobaId { get; set; }

        public int StafiId { get; set; }

        public string KlientiId { get; set; }

        public decimal Shuma { get; set; }

        public decimal ShumaPranuar { get; set; }

        public int InsertBy { get; set; }

        public DateTime? InsertDate { get; set; }

    }
}