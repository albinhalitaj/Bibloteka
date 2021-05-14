using System;

namespace Bibloteka.BusinessObjects
{
    public class LibriAutori
    {
        
        public int LibriAutoriId { get; set; }

      
        public string LibriId { get; set; }

        public int AutoriId { get; set; }

        public int? InsertBy { get; set; }

        public DateTime? InsertDate { get; set; }

        public int? Lub { get; set; }

        public int? Lun { get; set; }

        public DateTime? Lud { get; set; }
    }
}