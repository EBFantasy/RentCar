using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RentCar_Csharp.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public string GetUsers()
        {
            return "{id:198672948798346 name:Wales gender:male phoneN:0728596422 account:agent}\n" +
                   "{id:198671568324769 name:Noltz gender:female phoneN:0728523143 account:customer}\n";
        }
    }
}
