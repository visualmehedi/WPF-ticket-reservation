using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Seat
    {

        public int SeatNo { get; set; }          //array in the seat version

        public string Status { get { if (_isReserved) return "Reserved"; return "Vacant"; } }

        public bool _isReserved;     //true if the seat is reserved, false if vacant

        public string CustomerName { get; set; } //name of the ordering customer
        public decimal Price { get; set; }       //price of the seat(ticket)



        //Constructor
        public Seat(string name, decimal price, bool isReserved, int rNumber)
        {
            _isReserved = isReserved;
            CustomerName = name;
            Price = price;
            SeatNo = rNumber;
        }
    }
}
