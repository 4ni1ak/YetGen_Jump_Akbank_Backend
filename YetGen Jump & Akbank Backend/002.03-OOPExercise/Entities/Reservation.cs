using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002._03_OOPExercise.Entities
{
    internal class Reservation
    {
        public Reservation( ValueObject.Guest guest, DateTime checkInDate, DateTime checkOutDate)
        //public Reservation(Guest guest, DateTime checkInDate, DateTime checkOutDate)
          
        {
            Random random = new Random();
            Id = random.Next(100, int.MaxValue);  
            Guest = guest;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
        }

        public int Id { get; set; }
        public ValueObject.Guest Guest { get; set; }
        //public Guest Guest { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
    }
}
