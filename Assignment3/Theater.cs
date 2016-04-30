using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Theater
    {
        public Seat[] Seats { get; set; }

        public Theater()
        {
            int i;
            Seats = new Seat[60];
            for (i = 0; i <= 59; i++)
            Seats[i] = new Seat(" ", 0, false, i + 1);        
        }

        public Seat[] GetSeats()
        {
            return Seats;
        }

        /// <summary>
        /// Checking availablity of customer
        /// </summary>
        /// <returns></returns>
 
        public int GetAvailabaleSeatCount()
        {
            int count = 0;
            for (int i = 0; i < Seats.Length; i++)
            {
                if (!Seats[i]._isReserved)
                    count++;
            }
            return count;
        }

       /// <summary>
        /// Counting the  reserved seat
       /// </summary>
       /// <returns></returns>
        public int GetReservedSeatCount()
        {
            int count = 0;
            for (int i = 0; i < Seats.Length; i++)
            {
                if (Seats[i]._isReserved)
                    count++;
            }
            return count;
        }

        /// <summary>
        /// Booking Reservation for customer
        /// </summary>
        /// <param name="name"></param>
        /// <param name="seatId"></param>
        /// <param name="price"></param>
        /// <returns></returns>
        public bool BookReservation(string name, int seatId, decimal price)
        {
            if (name == "") return false;
            for (int i = 0; i < Seats.Length; i++)
            {
                if (Seats[i].SeatNo == seatId && !Seats[i]._isReserved)
                {
                    Seats[i].CustomerName = name;
                    Seats[i]._isReserved = true;
                    Seats[i].Price = price;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Reservation cancelation for customer
        /// </summary>
        /// <param name="seatId"></param>
        /// <returns></returns>
        public bool CancelReservation(int seatId)
        {
            for (int i = 0; i < Seats.Length; i++)
            {
                if (Seats[i].SeatNo == seatId)
                {
                    Seats[i].CustomerName = "";
                    Seats[i]._isReserved = false;
                    Seats[i].Price = 0;
                }
            }
            return true;
        }
    }
}
