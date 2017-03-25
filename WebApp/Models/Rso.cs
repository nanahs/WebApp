using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Rso
    {
        public int RsoId { get; set; }
        public string RsoName { get; set; }
        public int AdminId { get; set; }

        public Rso()
        {
            this.rsoMem = new HashSet<RsoMembership>();
        }

        public virtual IEnumerable<RsoMembership> rsoMem { get; set; }
    }
}
