using HotelReservations.Entities;
using HotelReservations.Validation;
using HotelReservations.Strategies;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservations.Services
{
    public class ReservationService 
    {
        public ReservationValidator _validator;
        public ReservationStrategy _reservationStrategy;

        public ReservationService()
        {
            _validator = new ReservationValidator();
            _reservationStrategy = new ReservationStrategy();
        }
        public void MakeReservation(Reservation reservation, Hotel hotel)
        {
            var validationResult = _validator.Validate(reservation);
            reservation.Result = "Decline";
            if (validationResult.IsValid && hotel!=null)
            {
                Room room = _reservationStrategy.FindBestRoom(hotel,reservation.StartDay, reservation.EndDay);
                if (room != null)
                {
                    reservation.Result = "Accept";
                    _reservationStrategy.BookDays(room,reservation.StartDay, reservation.EndDay);
                }
            }
            else
            {
                foreach (var failure in validationResult.Errors)
                {
                    Console.WriteLine("Failed validation. Error was: " + failure.ErrorMessage);
                }
            }
        }
    }
}
