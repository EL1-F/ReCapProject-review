﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class RentalValidator:AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(r=>r.CarId).NotNull();
            RuleFor(r=>r.CustomerId).NotNull();

            RuleFor(r => r.RentDate)
                .NotNull().WithMessage("Boş Geçilemez.")
                .GreaterThan(r=>DateTime.Now).WithMessage("Geçerli bir tarih giriniz.");
        }
    }
}
