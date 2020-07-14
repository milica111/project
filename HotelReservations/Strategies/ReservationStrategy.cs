using HotelReservations.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservations.Strategies
{
    public class ReservationStrategy : IRoomReservationStrategy, IHotelReservationStrategy
    {
        public Room FindBestRoom(Hotel hotel,int startDay, int endDay)
        {
            Room result = null;
            var daysBefore = startDay;
            foreach (var room in hotel.Rooms)
            {
                var days = AvailAbleDaysBefore(room,startDay);
                var isAvailAble = IsAvailAble(room,startDay, endDay);
                if (isAvailAble == true && days <= daysBefore)
                {
                    result = room;
                    daysBefore = days;
                }
            }
            return result;
        }

        private bool IsAvailAble(Room room,int startDay, int endDay)
        {
            var result = true;
            for (int i = startDay; i < endDay + 1; i++)
            {
                if (room.AvailableDays[i] == 1)
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
        private int AvailAbleDaysBefore(Room room,int day)
        {
            var result = 0;
            for (int i = day - 1; i >= 0; i--)
            {
                if (room.AvailableDays[i] == 0)
                {
                    result++;
                }
                 else break;
            }
            return result;
        }

        public void BookDays(Room room,int startDay, int endDay)
        {
            var days = endDay - startDay + 1;
            for (int a = 0; a < days; a++)
            {
                room.AvailableDays[startDay + a] = 1;
            }
        }

    }
}
