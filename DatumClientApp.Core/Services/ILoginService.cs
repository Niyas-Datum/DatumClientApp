using DatumClientApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatumClientApp.Core.Services
{
    public interface ILoginService
    {
        Task<TbClientRegistration> Login(string username, string password);
    }
}
