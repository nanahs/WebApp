using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class UserType
    {
        public int UserTypeId { get; set; }
        public string RoleName { get; set; }

        public override string ToString()
        {
            return RoleName;
        }
    }
}
