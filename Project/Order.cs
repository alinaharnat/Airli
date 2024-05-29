using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public enum SeatClass
    {
        Econom,
        Buisiness,
        First
    }
    public class Order
    {
        private Flights fligth;
        private int numSeats;
        private double totalPrice;
        private string infoOrder;
        private User curUser;
        private SeatClass seat;
        public Flights Flights { get; set; }
        public int NumSeats { get; set; }
        public double TotalPrice { get; set; }
        public string InfoOrder { get { return $"Місто відправлення:{fligth.DepartureCity} \nМісто прибуття:{fligth.DepartureCity} \nНомер рейсу:{fligth.Id}  \nДата:{fligth.DateTime} \nТривалість:{fligth.FlightDuration} \nАвіакомпанія:{fligth.Carrier} \nКількість замовлених місць:{numSeats} \nЗагальна сума замовлення:{totalPrice}"; } }
        public User CurUser { get; set; }
        public SeatClass Seat { get; set; }
        public Order(Flights flight)
        {
            this.fligth = flight;
        }
        public  void  MakeNewOrder(User user, int numSeats,string seatClass)
        {
           
                totalPrice = (double)numSeats * Convert.ToDouble(fligth.Price);
                fligth.NumberOfAvailableSeats -= numSeats;
                user.HistoryOfOrders.Add(infoOrder);
            }
          
        }

    }
