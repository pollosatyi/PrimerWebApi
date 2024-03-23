using Microsoft.Extensions.Logging;
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
        private readonly IUserRepository _userRepository;
        private readonly ILogger<UserLogic> _logger;

        public UserLogic(IUserRepository userRepository,ILogger<UserLogic>logger)
        {
            _userRepository = userRepository;
            _logger = logger;
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
            _userRepository.CreateAsync(userDb);
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
