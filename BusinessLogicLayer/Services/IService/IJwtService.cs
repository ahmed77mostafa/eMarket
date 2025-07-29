using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services.IService
{
    public interface IJwtService
    {
        string GenerateToken(string userId, string userEmail, IList<string> roles);
    }
}
