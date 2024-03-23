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
                FirstName = user.FirstName,
                LastName = user.LastName,
                MiddleName = user.MiddleName,
                NumberPhone = user.NumberPhone,
                Age = user.Age
            };
            _userRepository.Add(userDb);
        }

        public User Get(int id)
        {
            return new User();
        }

        public List<User> Get()
        {
            return _userRepository.Get();
        }
    }
}
