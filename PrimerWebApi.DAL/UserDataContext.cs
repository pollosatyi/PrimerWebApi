using Microsoft.Data.SqlClient;
using PrimerWebApi.Common.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerWebApi.DAL
{
    public class UserDataContext:IUserDataContext
    {
        public List<User> _UsersData {  get; set; }
        public UserDataContext() { 
          _UsersData=new List<User>();
        
        }

        public User Get(int id)
        {
            return _UsersData.FirstOrDefault(x => x.Id == id);
        }
    }
}
