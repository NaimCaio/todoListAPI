
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImpactaAPI.Models.Interfaces
{
    public interface IHash
    {
        string HashPassowrd(string password);

        bool ValidateUser(string loginAccountPassword, string baseAccountPassword);
    }
}
