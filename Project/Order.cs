using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public class Order
    {
        private Flight flight;
        private int numSeats;
        private double totalPrice;
        private string infoOrder;
        private string seatClass;
        private int handB;
        private int registratedB;
        private DateTime date;
        //private bool state;
        //private Timer orderTimer;

        //
        public Flight Flight { get { return flight; } set { flight = value; } }
        public int NumSeats { get { return numSeats; } set { numSeats = value; } }
        public double TotalPrice { get { return totalPrice; } set { totalPrice = value; } }
        public string InfoOrder { get { return infoOrder; } private set { infoOrder = value; } }
        public int HandB { get { return handB; } set { handB = value; } }
        public int RegistratedB { get { return registratedB; } set { registratedB = value; } }
        public string SeatClass { get { return seatClass; } set { seatClass = value; } }
        public DateTime Date { get; set; }
        //public bool State { get; set; }
        //public Timer OrderTimer { get; set; }

        public Order(Flight flight, int numSeats, string seatClass, int handB, int registratedB)
        {
            this.flight = flight;
            this.handB = handB;
            this.registratedB = registratedB;
            this.numSeats = numSeats;
            this.seatClass = seatClass;
            this.date = DateTime.Now;
            this.totalPrice = CountTotalPrice();
            this.infoOrder = $"Місто відправлення:{flight.DepartureCity}\nМісто прибуття:{flight.DestinationCity} \nМісто пересадки:{flight.IntermediateLandingPoint}\nНомер рейсу:{flight.Id}  \nДата:{flight.DateTime} \nТривалість:{flight.FlightDuration} \nАвіакомпанія:{flight.Carrier}\nКлас:{seatClass} \nКількість замовлених місць:{NumSeats} \nЗагальна сума замовлення:{TotalPrice}";
           
            
        }
        // user.unpaidUserOrders.Add();

   
        public  double CountTotalPrice()
        {
            double res = (numSeats * flight.Price) + (flight.Price * (handB * 0.25 + registratedB * 1.5));
            switch (seatClass)
            {
                case "econom":
                    flight.SeatsEconom -= numSeats;
                    break;
                case "business":
                    res *= 1.05;
                    flight.SeatsBuisiness -= numSeats;
                    break;
                case "first":
                    res *= 1.1;
                    flight.SeatsFirst -= numSeats;
                    break;
            }
            flight.NumberOfAvailableSeats -= numSeats;
            totalPrice = Math.Round(res);
            return totalPrice;

            
        
        }
          
        }
    //public static bool PayOrder(Order order, User user)
    //{

    //}

    }
