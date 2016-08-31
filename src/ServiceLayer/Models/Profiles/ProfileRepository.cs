using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace ServiceLayer.Models.Profiles
{
    public class ProfileRepository : IProfileRepository
    {
        private static ConcurrentDictionary<string, Profile> _userProfile =
             new ConcurrentDictionary<string, Profile>();
        public IEnumerable<Profile> GetAll()
        {
            return _userProfile.Values;
        }

        public string Add(Profile userProfile)
        {
            userProfile.ProfileID = Guid.NewGuid().ToString();
            _userProfile.TryAdd(userProfile.ProfileID, userProfile);
            return "added";
        }

        public string Remove(Profile userProfile)
        {
            return "blh";

        }

        public string Update(Profile userProfile)
        {
            return "bsjd";
        }

        public Profile Find(string name)
        {
            Profile _profile;
            _userProfile.TryGetValue(name, out _profile);
            return _profile;
        }

    }
}

