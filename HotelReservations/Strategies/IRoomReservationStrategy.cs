using HotelReservations.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservations.Strategies
{
    public interface IRoomReservationStrategy
    {
        void BookDays(Room room, int startDay, int endDay);
    }
}
