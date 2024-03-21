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
        private  IUserDataContext _userDataContext;
        public UserLogic(IUserRepository userRepository, IUserDataContext userDataContext)
        {
            _userRepository = userRepository;
            _userDataContext = userDataContext;
        }

        
        public void Create(User user)
        {
            var userDb = new User()
            {
                Firstname = user.Firstname,
                Lastname = user.Lastname
            };
            _userRepository.Add(userDb);
        }

        public User Get(int id)
        {
           return _userDataContext.Get(id);
        }
    }
}
