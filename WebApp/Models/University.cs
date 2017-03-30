using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class University
    {
        public int UniversityId { get; set; }
        public int LocationId { get; set; }
        public int NumberOfStudents { get; set; }
        public int DescriptionId { get; set; }
    }

    public class WebUniversity
    {
        public string Name { get; set; }
        public string Abbrev { get; set; }
        public string Loc { get; set; }
        public decimal Lati { get; set; }
        public decimal Longi { get; set; }
        public int NumStud { get; set; }
        public string Descr { get; set; }
    }
}
