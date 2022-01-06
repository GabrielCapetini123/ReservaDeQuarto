using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp20.Entities
{
    class Reservation
    {
        public int roomNumbers { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {
        }

        public Reservation(int roomNumbers, DateTime checkIn, DateTime checkOut)
        {
            this.roomNumbers = roomNumbers;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            checkIn = checkIn;
        }
        public override string ToString()
        {
            return "Room "
                + roomNumbers
                + ", "
                + "Checkin : "
                + CheckIn.ToString("dd/MM/yyyy")
                + (", check-out : ")
                + CheckOut.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + " nights";

        }
    }
}
