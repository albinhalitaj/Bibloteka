using System;

namespace Bibloteka.BusinessObjects
{
    public class Autori
    {
        public int AutoriId { get; set; }

        public string Emri { get; set; }

        public string Mbiemri { get; set; }

        public string Gjinia { get; set; }

        public DateTime? Datalindjes { get; set; }

        public string InsertBy { get; set; }

        public DateTime? InsertDate { get; set; }

        public int? Lub { get; set; }

        public int? Lun { get; set; }

        public DateTime? Lud { get; set; }
    }
}