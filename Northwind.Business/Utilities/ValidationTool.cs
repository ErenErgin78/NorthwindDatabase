using FluentValidation;
using Northwind.Business.ValidationRules.FluentValidation;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Utilities
{
    public static class ValidationTool
    {
        public static void Validatee(object entity, IValidator validator)
        {
            var context = new ValidationContext<object>(entity);
            var errors = validator.Validate(context);
            if (errors.Errors.Count != 0) { throw new ValidationException(errors.Errors); }
        }
    }
}