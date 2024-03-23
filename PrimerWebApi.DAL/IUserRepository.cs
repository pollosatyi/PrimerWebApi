using PrimerWebApi.Common.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerWebApi.DAL
{
    public interface IUserRepository
    {
        public  Task CreateAsync(User user);
    }
}
