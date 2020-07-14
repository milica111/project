using HotelReservations.Entities;
using HotelReservations.Services;
using System;
using System.Collections.Generic;
using Xunit;

namespace XUnitTestHotelReservation
{
    public class HotelReservationsTest
    {
        public HotelService _hs;
        public ReservationService _rs;
        public HotelReservationsTest()
        {
           _hs = new HotelService();
           _rs = new ReservationService();
        }

        //1a-1b cases

        [Theory(DisplayName ="When request is outside our planning period Then that request should be declined")]

        [InlineData(-4,2)]
        [InlineData(200, 400)]
        public void test(int startDay, int endDay)
        {
                var hotel = _hs.CreateHotel(2);

                Reservation reservation = new Reservation(startDay, endDay);
                _rs.MakeReservation(reservation, hotel);
                var actualResult = reservation.Result;

                Assert.Equal("Decline", actualResult);
            
        }
        // 2,3,4,5 cases

        

        [Theory(DisplayName = "When request is/is not accepted Then reservation result should be accept/decline")]
        [MemberData(nameof(Booking.Data), MemberType = typeof(Booking))]

        // bookingList has list of request(startDay,endDay, expectedResult) and size of hotel

        public void test2(List<Reservation> bookingList, int hotelSize)
        {
            var hotel = _hs.CreateHotel(hotelSize);

            foreach (var i in bookingList)
            {
                var expectedResult = i.Result;
                Reservation reservation = new Reservation(i.StartDay, i.EndDay);
                _rs.MakeReservation(reservation, hotel);

                var actualResult = reservation.Result;

                Assert.Equal(expectedResult, actualResult);
            }
        }
    }
}
