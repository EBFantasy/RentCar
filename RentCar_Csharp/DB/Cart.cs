using RentCar_Csharp.Models;

namespace RentCar_Csharp.DB
{
    public class Cart
    {
        public User? user;
        public List<Reservation> Reservations = new List<Reservation>();

        public Cart(User user) { this.user = user; }
        /*
        public void AddReservation(Car car) 
        {
            if (car == null) throw new ArgumentNullException("No car");
            if (user == null) throw new ArgumentNullException("No user");
            Reservations.Add(new Reservation(car, user));
        }
        */

        public bool ClearCart()
        {
            if (Reservations.Count == 0) return false;
            Reservations.Clear();
            return true;
        }

    }
}

