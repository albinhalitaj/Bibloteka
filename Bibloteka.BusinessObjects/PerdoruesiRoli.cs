using System;

namespace Bibloteka.BusinessObjects
{
    public class PerdoruesiRoli
    {
        public int PerdoruesiRoliId { get; set; }
        public int PerdoruesiId { get; set; }
        public int RoliId { get; set; }
        public string Pershkrimi { get; set; }
        public int? InsertBy { get; set; }
        public DateTime? InsertDate { get; set; }
        public int? Lub { get; set; }
        public int? Lun { get; set; }
        public DateTime? Lud { get; set; }
    }
}