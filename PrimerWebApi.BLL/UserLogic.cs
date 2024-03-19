using PrimerWebApi.Common.Users;
using PrimerWebApi.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerWebApi.BLL
{
    public class UserLogic : IUserLogic
    {
        private IUserRepository _userRepository;
        public UserLogic(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void Create(User user)
        {
            var userDb = new User()
            {
                name = user.name,
                lastname = user.lastname
            };
            _userRepository.Add(userDb);
        }
    }
}
