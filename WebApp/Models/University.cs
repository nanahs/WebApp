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
        public string name { get; set; }
        public string abbrev { get; set; }
        public string loc { get; set; }
        public decimal lati { get; set; }
        public decimal longi { get; set; }
        public int numStud { get; set; }
        public string desc { get; set; }
    }
}
