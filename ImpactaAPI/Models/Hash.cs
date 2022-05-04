using ImpactaAPI.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BCryptNet = BCrypt.Net.BCrypt;

namespace ImpactaAPI.Models
{
    public class Hash : IHash
    {
        public string HashPassowrd(string password)
        {
            var hash = BCryptNet.HashPassword(password);
            return hash;
        }

        public bool ValidateUser(string loginAccountPassword, string baseAccountPassword)
        {
            var auth = BCryptNet.Verify(loginAccountPassword, baseAccountPassword);

            return auth;
        }
    }
}
