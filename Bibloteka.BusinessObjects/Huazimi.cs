using System;

namespace Bibloteka.BusinessObjects
{
    public class Huazimi
    {
        public int HuazimiId { get; set; }

        public string LibriId { get; set; }

        public string KlientiId { get; set; }

        public int NumriKopjeve { get; set; }

        public DateTime DataHuazimi { get; set; }

        public DateTime DataKthimit { get; set; }

        public bool Statusi { get; set; }

        public string Pershkrimi { get; set; }

        public int? InsertBy { get; set; }

        public DateTime? InsertDate { get; set; }

        public int? Lub { get; set; }

        public int? Lun { get; set; }

        public DateTime? Lud { get; set; }
    }
}