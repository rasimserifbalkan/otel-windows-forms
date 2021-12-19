using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Otel.Business.ExtensionMethods
{


    //extension methods

    public static class ValidationExtensions
    {
        //this ifadesi aslında bu methodun .ToString() gibi sadece string ifadelerin sonunda çıkmasına yarar.
        public static bool CheckEmail(this string email) 
        {
            return Regex.IsMatch(email, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }
    }
}
