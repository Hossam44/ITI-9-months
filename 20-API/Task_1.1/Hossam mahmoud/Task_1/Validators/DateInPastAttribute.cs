using System.ComponentModel.DataAnnotations;

namespace Task_1.Validators
{
    public class DateInPastAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            return value is DateTime date && date < DateTime.Now;
        }
    }
}
