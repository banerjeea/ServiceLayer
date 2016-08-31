
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceLayer.Models.Registration
{
    /// <summary>
    /// Regitration  model represents
    /// objects needed to add/emove/update
    /// a new user.
    /// </summary>
    public class Registration
    {
        public string RegistrationNumber { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        
    }
}
 