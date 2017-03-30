using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int UniversityId { get; set; }
        public int UserTypeId { get; set; }

        public User()
        {
            this.rsoMem = new HashSet<RsoMembership>();
        }

        public virtual IEnumerable<RsoMembership> rsoMem { get; set; }

        public override string ToString()
        {
            char splitChar = '~';
            return UserId + splitChar + FirstName + splitChar + LastName + splitChar + Email + splitChar + Password + splitChar + UniversityId + splitChar + UserTypeId;
        }
    }
}
