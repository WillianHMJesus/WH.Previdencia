﻿using FluentValidation;
using FluentValidation.Results;
using System;

namespace WH.Previdencia.Domain.Core
{
    public abstract class Entity
    {
        public Guid Id { get; protected set; }
        public bool Valid { get; private set; }
        public ValidationResult ValidationResult { get; set; }

        public bool Validate<TModel>(TModel model, AbstractValidator<TModel> validator)
        {
            ValidationResult = validator.Validate(model);
            return Valid = ValidationResult.IsValid;
        }
    }
}