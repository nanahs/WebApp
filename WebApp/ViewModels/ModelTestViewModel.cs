using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.ViewModels
{
    public class ModelTestViewModel
    {

        public IEnumerable<User> Users { get; set; }
        public IEnumerable<RsoMember> Members { get; set; }

        public ModelTestViewModel(IEnumerable<User> users, IEnumerable<RsoMember> mems)
        {
            Users = users;
            Members = mems;
        }

    }
}
