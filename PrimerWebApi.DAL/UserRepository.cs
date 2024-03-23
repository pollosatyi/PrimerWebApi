using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using Npgsql;
using PrimerWebApi.Common.Users;

namespace PrimerWebApi.DAL
{
    public class UserRepository : IUserRepository
    {
        private readonly UserContext _dbContext;
        private readonly ILogger<UserRepository> _logger;
        public UserRepository(UserContext userContext,ILogger<UserRepository>logger)
        {
            _dbContext = userContext;
            _logger = logger;
        }

        public async Task CreateAsync(User user)
        {
            try
            {
                await _dbContext.Users.AddAsync(user);
                await _dbContext.SaveChangesAsync();
            }
            catch { 
            }
        }
    }
}
