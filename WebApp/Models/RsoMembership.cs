using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class RsoMembership
    {
        [Key]
        public int RsoMemberId { get; set; }
        public int RsoId { get; set; }
        public int UserId { get; set; }

        public virtual Rso rso { get; set; }
        public virtual User user { get; set; }
    }
}
