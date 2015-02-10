using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Demo.App_Infrastructure
{
    public class BeforeTodayAttribute : ValidationAttribute
    {
        public BeforeTodayAttribute()
            : base("The date must be later than today")
        {

        }
        public override bool IsValid(object value)
        {
            if( value == null)
            { 
                return true;
            }

            return value is DateTime && ((DateTime)value) > DateTime.Today;
        }

    }
}