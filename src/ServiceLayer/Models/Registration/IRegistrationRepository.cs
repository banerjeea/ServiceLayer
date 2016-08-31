/*It's a repository interface. A repository is an object 
that encapsulates the data layer, and contains logic for
retrieving data and mapping it to an entity model.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceLayer.Models.Registration
{
    public interface IRegistrationRepository
    {
        string Add(Registration register);
        string Remove(Registration register);
        string Update(Registration register);
        void EmailConfirmation();
    }
}
