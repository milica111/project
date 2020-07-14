using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservations.Entities
{
    public class Room
    {
        public int[] AvailableDays { get; set; }

        public Room()
        {
            AvailableDays = new int[365];
        }

    }
}
