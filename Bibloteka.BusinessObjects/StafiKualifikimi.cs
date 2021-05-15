using System;

namespace Bibloteka.BusinessObjects
{
    public class StafiKualifikimi
    {
        public int StafiKualifikimiId { get; set; }
        public int StafiId { get; set; }
        public int KualifikimiId { get; set; }
        public string Pershkrimi { get; set; }
        public int? InsertBy { get; set; }
        public DateTime? InsertDate { get; set; }
        public int? Lub { get; set; }
        public int? Lun { get; set; }
        public DateTime? Lud { get; set; }
    }
}