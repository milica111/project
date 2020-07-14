using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservations.Entities
{
    public class Reservation
    {
        public int StartDay { get; set; }
        public int EndDay { get; set; }
        public string Result { get; set; }

        public Reservation(int startDay, int endDay)
        {
            StartDay = startDay;
            EndDay = endDay;
        }

        public Reservation(int startDay, int endDay, string result) 
        {
            StartDay = startDay;
            EndDay = endDay;
            Result = result;
        }
    }
}
