using FluentValidation;
using HotelReservations.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservations.Validation
{
    public class HotelValidator : AbstractValidator<Hotel>
    {
        public HotelValidator()
        {
            RuleFor(hotel => hotel.Size).GreaterThan(0).WithMessage("Hotel must have at least one room")
                                        .LessThanOrEqualTo(1000).WithMessage("Hotel must have less then 1001 rooms");
        }
    }
}
