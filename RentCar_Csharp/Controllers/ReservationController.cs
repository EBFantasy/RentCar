using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace RentCar_Csharp.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        [HttpGet]
        public string GetReservations ()
        {
            return "{carID:15815875 userID:1589179347 date:2022-1-4 price:179999$ reserID:1968086703958}";
        }
    }
}
