//Implementation of Irepository.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace ServiceLayer.Models.Registration
{
    public class RegistrationRepository : IRegistrationRepository
    {
        private static ConcurrentDictionary<string, Registration> _userData =
              new ConcurrentDictionary<string, Registration>();


        public string Add(Registration userData)
        {
            userData.RegistrationNumber = Guid.NewGuid().ToString();
            _userData.TryAdd(userData.RegistrationNumber, userData);
            return "blsh";
        }

        public string Remove(Registration userData)
        {
            return "blh";

        }

        public string Update(Registration userData)
        {
            return "bsjd";
        }

        public void EmailConfirmation()
        {

        }
    }
}
