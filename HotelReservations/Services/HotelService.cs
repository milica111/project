using HotelReservations.Entities;
using HotelReservations.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservations.Services
{
    public class HotelService 
    {
        public HotelValidator _validator;
        public HotelService()
        {
            _validator = new HotelValidator();
        }
        public Hotel CreateHotel(int size)
        {
            Hotel hotel = new Hotel(size);
            
            var validationResult = _validator.Validate(hotel);
            if (validationResult.IsValid)
            {
                return hotel;
            }
            else
            {
                foreach (var failure in validationResult.Errors)
                {
                    Console.WriteLine("Failed validation. Error was: " + failure.ErrorMessage);
                }
                return null;
            }
        }
    }
}
