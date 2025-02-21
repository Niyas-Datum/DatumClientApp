using DatumClientApp.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatumClientApp.Core.Services
{
    public class LoginService : ILoginService
    {
        private readonly DbclientContext _dbclientContext;
        public LoginService(DbclientContext dbclientContext)
        {
           _dbclientContext = dbclientContext;
            
        }
       

        async Task<TbClientRegistration> ILoginService.Login(string username, string password)
        {
            return  await _dbclientContext.TbClientRegistrations.Where(x => x.Username == username && x.Password == password).FirstOrDefaultAsync();

        }
    }
}
