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
        private Flights flight;
        private int numSeats;
        private int totalPrice;
        private string infoOrder;
        private string seatClass;
        private int handB;
        private int registratedB;
        private bool state;
        private Timer orderTimer;
        

        public Flights Flight { get; set; }
        public int NumSeats { get; set; }
        public double TotalPrice { get; set; }
        public string InfoOrder { get { return infoOrder; } private set {} }
        public int HandB { get; set; }
        public int RegistrationB { get; set; }
        public string SeatClass { get; set; }
        public bool State { get; set; }
        public Timer OrderTimer { get; set; }

        public Order(User user,Flights flight, int numSeats, string seatClass, int handB, int registratedB)
        {
            this.flight = flight;
            this.handB = handB;
            this.registratedB = registratedB;
            this.NumSeats = numSeats;
            //flight.NumberOfAvailableSeats -= numSeats;  
            this.CountTotalPrice();
            this.infoOrder = $"Місто відправлення:{flight.DepartureCity}\nМісто прибуття:{flight.DestinationCity} \nМісто пересадки:{flight.IntermediateLandingPoint}\nНомер рейсу:{flight.Id}  \nДата:{flight.DateTime} \nТривалість:{flight.FlightDuration} \nАвіакомпанія:{flight.Carrier}\nКлас:{seatClass} \nКількість замовлених місць:{NumSeats} \nЗагальна сума замовлення:{totalPrice}";
            user.HistoryOfOrders.Add(this);
        }
        // user.unpaidUserOrders.Add(this);

   
        public  int  CountTotalPrice()
        {
            var res = ((double)numSeats * Convert.ToDouble(flight.Price)) + (Convert.ToDouble(flight.Price)* Convert.ToDouble(handB * 0.25 + registratedB * 1.5));
            switch(seatClass)
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
            totalPrice = (int)Math.Round(res);
            return totalPrice;
            
                //fligth.NumberOfAvailableSeats -= numSeats;
                //user.HistoryOfOrders.Add(infoOrder);
            }
          
        }
    //public static bool PayOrder(Order order, User user)
    //{

    //}

    }
