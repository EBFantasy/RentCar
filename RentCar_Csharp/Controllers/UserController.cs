using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentCar_Csharp.Models;

namespace RentCar_Csharp.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        /*
        [HttpGet]
        public string GetUsers()
        {
            return "{userId: name: gender: phoneN: account:agent}\n" +
                   "{userId:198671568324769 name:Noltz gender:female phoneN:0728523143 account:customer}\n";
        }
        */

        [HttpPost]
        public string PostCars([FromBody] User value)
        {
            return string.Format("userID={0}, name={1}, gender={2}, phoneN={3}, account={4}", value.userId, value.name, value.gender, value.phoneN, value.account);
        }
    }
}

