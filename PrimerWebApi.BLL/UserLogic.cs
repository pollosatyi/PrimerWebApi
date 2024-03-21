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
        public UserLogic(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public UserLogic(IUserDataContext userDataContext)
        {
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

        public void Get(int id)
        {
            _userDataContext.Get(id);
        }
    }
}
