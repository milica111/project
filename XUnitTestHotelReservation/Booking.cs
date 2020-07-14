using HotelReservations.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTestHotelReservation
{
    public static class Booking
    {
        public static IEnumerable<object[]> Data =>
            new List<object[]>
            {
                new object[]
                {
                    //list of request(startDay,endDay, expectedResult) and size of hotel

                    new List<Reservation>()
                    {
                    new Reservation(0,5,"Accept"),
                    new Reservation(7,13,"Accept"),
                    new Reservation(3,9,"Accept"),
                    new Reservation(5,7,"Accept"),
                    new Reservation(6,6,"Accept"),
                    new Reservation(0,4,"Accept")
                    },
                    3
                } ,
                new object[]
                {
                   
                    new List<Reservation>()
                    {
                    new Reservation(1,3,"Accept"),
                    new Reservation(2,5,"Accept"),
                    new Reservation(1,9,"Accept"),
                    new Reservation(0,15, "Decline")
                    },
                    3
                } ,
                new object[] { new List<Reservation>() {
                    new Reservation(1,3,"Accept"),
                    new Reservation(0,15,"Accept"),
                    new Reservation(1,9,"Accept"),
                    new Reservation(2,5, "Decline"),
                    new Reservation(4,9,"Accept")
                },
                    3
                },
                new object[] { new List<Reservation>() {
                    new Reservation(1,3,"Accept"),
                    new Reservation(0,4,"Accept"),
                    new Reservation(2,3,"Decline"),
                    new Reservation(5,5, "Accept"),
                    new Reservation(4,10,"Accept"),
                    new Reservation(10,10,"Accept"),
                    new Reservation(6,7,"Accept"),
                    new Reservation(8,10,"Decline"),
                    new Reservation(8,9, "Accept")
                },
                    2
                }
            };
    }
}
