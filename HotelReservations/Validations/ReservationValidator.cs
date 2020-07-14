using FluentValidation;
using HotelReservations.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservations.Validation
{
    public class ReservationValidator : AbstractValidator<Reservation>
    {
        public ReservationValidator()
        {
            RuleFor(reservation => reservation.StartDay) .LessThanOrEqualTo(365).WithMessage("Start day must be less than 366.")
                                                        .GreaterThanOrEqualTo(0).WithMessage("Start day must be greater than -1.");

            RuleFor(reservation => reservation.EndDay) .GreaterThanOrEqualTo(0).WithMessage("End day must be greater than -1.")
                                                      .LessThanOrEqualTo(365).WithMessage("End day must be less than 366.")
                                                      .GreaterThanOrEqualTo(x => x.StartDay).WithMessage("Start day must be before end day.");

        }
    }
}
