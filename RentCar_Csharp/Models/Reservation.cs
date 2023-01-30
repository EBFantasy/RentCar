
namespace RentCar_Csharp.Models
{
    public class Reservation
    {
        public int carId { get; set; }
        public int userId { get; set; }
        public int reservationId { get; set; }

        public DateTime? Date { get; set; } = DateTime.Now;
        public double Price { get; set; }

        public Reservation(Car car, User user) 
        {  
            carId= car.Id;
            userId= user.Id;
            Price = car.Price;
        }




    }
}

