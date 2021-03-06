﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.Mvc;

namespace SimpleCMS.Tests.Helpers
{
    public static class ControllerExtensions
    {
        public static void SetupContext(this Controller controller, object entity)
        {
            var validationContext = new ValidationContext(entity, null, null);
            var validationResults = new List<ValidationResult>();
            Validator.TryValidateObject(entity, validationContext, validationResults);
            foreach (var validationResult in validationResults)
            {
                controller.ModelState.AddModelError(validationResult.MemberNames.First(), validationResult.ErrorMessage);
            }
        }
    }
}