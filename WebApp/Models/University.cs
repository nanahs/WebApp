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
}
