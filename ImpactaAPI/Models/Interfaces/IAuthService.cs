using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImpactaAPI.Models.Interfaces
{
    public interface IAuthService
    {
        User AutheticateUser(User user);
        User AddUser(User user);
        User DeleteUser(string userEmail);
        User UpdateUser(User user);
    }
}
