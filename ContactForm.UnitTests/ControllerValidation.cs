using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ContactForm.UnitTests
{
	internal static class ControllerValidation
	{
		internal static void SimulateValidation(this ControllerBase controller, object model)
		{
			// mimic the behaviour of the model binder which is responsible for Validating the Model
			var validationContext = new ValidationContext(model, null, null);
			var validationResults = new List<ValidationResult>();
			Validator.TryValidateObject(model, validationContext, validationResults, true);
			foreach (var validationResult in validationResults)
			{
				controller.ModelState.AddModelError(validationResult.MemberNames.First(), validationResult.ErrorMessage);
			}
		}
	}
}
