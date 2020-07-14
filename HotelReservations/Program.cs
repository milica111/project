using HotelReservations.Entities;
using HotelReservations.Services;
using System;

namespace HotelReservations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type size of hotel?");
            string inputSize = Console.ReadLine();
            int size;
            HotelService _hs = new HotelService();
            var hotel = Int32.TryParse(inputSize, out size) ? _hs.CreateHotel(size) : null;
            while (hotel != null)
            {
                Console.WriteLine("Please type start day of your reservation?");
                string inputStartDay = Console.ReadLine();
                int startDay, endDay;   
                Console.WriteLine("Please type end day of your reservation?");
                string inputEndDay = Console.ReadLine();
                if (Int32.TryParse(inputEndDay, out endDay) && Int32.TryParse(inputStartDay, out startDay))
                {
                    ReservationService _rs = new ReservationService();
                    Reservation reservation = new Reservation(startDay, endDay);
                    _rs.MakeReservation(reservation, hotel);
                    Console.WriteLine(reservation.Result);
                }
                else
                {
                    Console.WriteLine("Start day and end day should be number");
                }
            }
        }
    }
}