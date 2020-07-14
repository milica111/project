using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservations.Entities
{
    public class Hotel
    {
        public int Size { get; set; }
        public List<Room> Rooms { get; set; }

        public Hotel(int size)
        {
            Size = size;
            Rooms = new List<Room>();
            for (int i = 0; i < Size; i++)
            {
                var room = new Room();
                Rooms.Add(room);
            }
        }
       
    }
}
