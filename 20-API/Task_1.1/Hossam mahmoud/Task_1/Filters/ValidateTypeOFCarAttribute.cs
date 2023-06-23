using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Text.RegularExpressions;
using Task_1.Models;

namespace Task_1.Filters
{
    public class ValidateTypeOFCarAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Car? car = context.ActionArguments["newCar"] as Car;
            var regex = new Regex("^(Gas|Electric|Diesel|Hybrid)$",RegexOptions.IgnoreCase,TimeSpan.FromSeconds(2));


            if(car != null || regex.IsMatch(car!.Type!))
            {
                context.ModelState.AddModelError("Type","Error in Type of Car Energy");
                context.Result = new BadRequestObjectResult(context.ModelState);
            }
        }
    }
}
