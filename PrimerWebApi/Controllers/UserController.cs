using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PrimerWebApi.BLL;
using PrimerWebApi.Common.Users;

namespace PrimerWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserLogic _userLogic;

        public UserController(IUserLogic userLogic)
        {
            _userLogic = userLogic;
        }

        [HttpPost]
        public void Post([FromBody] User user)
        {
            _userLogic.Create(user);
        }
    }
}
