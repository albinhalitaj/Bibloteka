using System;

namespace Bibloteka.BusinessObjects
{
    public class LibriDetalet
    {
        public string LibriId { get; set; }

        public int Editioni { get; set; }

        public int NumriKopjeve { get; set; }

        public int? InsertBy { get; set; }

        public DateTime? InsertDate { get; set; }

        public int? Lub { get; set; }

        public int? Lun { get; set; }

        public DateTime? Lud { get; set; }
    }
}