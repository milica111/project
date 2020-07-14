using HotelReservations.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservations.Strategies
{
    public interface IHotelReservationStrategy
    {
        Room FindBestRoom(Hotel hotel, int startDay, int endDay);
    }
}
