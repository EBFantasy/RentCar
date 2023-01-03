using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RentCar_Csharp.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        [HttpGet]
        public string GetCarts()
        {
            return "A list here";
        }
    }
}
