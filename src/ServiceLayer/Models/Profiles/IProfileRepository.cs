using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceLayer.Models.Profiles
{
    public interface IProfileRepository
    {
        IEnumerable<Profile> GetAll();
        string Add(Profile profile);
        string Remove(Profile profile);
        string Update(Profile profile);
        Profile Find(string name);
    }
}
