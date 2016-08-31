using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceLayer.Models.Profiles
{
    public class Profile
    {
        public string ProfileID { get; set; }
        public string ProfileName { get; set; }
        public string ProfileCategory { get; set; }
        public string Description { get; set; }
    }
}
