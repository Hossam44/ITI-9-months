using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Day_5.Models
{
    public class MinSalary : ValidationAttribute
    {
        decimal Value;
        public MinSalary(int num)
        {
            Value = num;
        }
        public override bool IsValid(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            else
            {
                if (obj is decimal)
                {
                    decimal suppliedValue = (decimal)obj;
                    if (suppliedValue > Value)
                    {
                        return true;
                    }
                    else
                    {
                        ErrorMessage = "Min value for ID should be Large than " + Value; //user validation error
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
        }
    }
}