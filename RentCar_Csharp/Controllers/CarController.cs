﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentCar_Csharp.Models;

namespace RentCar_Csharp.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Car> GetCars()
        {
            return new Car[] { new Car()
                {
                    Id = 1,
                    Mark = "Benz",
                    Price = 180000.00,
                    Stock = 5
                },new Car()
                {
                    Id = 2,
                    Mark = "BWM",
                    Price = 145000.00,
                    Stock = 18
                }
            };
        }

        [HttpPost]
        public string PostCars()
        {
            return "Done";
        }

        [HttpDelete]
        public string DeleteCars()
        {
            return "Delete successful";
        }
    }
}
