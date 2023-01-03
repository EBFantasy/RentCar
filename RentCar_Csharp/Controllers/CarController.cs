using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RentCar_Csharp.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        [HttpGet]
        public string GetCars()
        {
            return "{id:49138567 mark:Benz price:180000$ stock:5}";
        }
    }
}
