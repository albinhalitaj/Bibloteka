using System;

namespace Bibloteka.BusinessObjects
{
    public class Tipi
    {
        public int TipiId { get; set; }

        public string Emri { get; set; }

        public string Pershkrimi { get; set; }

        public int? InsertBy { get; set; }

        public DateTime? InsertDate { get; set; }

        public int? Lub { get; set; }

        public int? Lun { get; set; }

        public DateTime? Lud { get; set; }
    }
}