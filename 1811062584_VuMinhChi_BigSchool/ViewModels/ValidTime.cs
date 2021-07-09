using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1811062584_VuMinhChi_BigSchool.ViewModels
{
    public class ValidTime : ValidationAttribute
    {
        [Authorize]
        [HttpPost]

        public override bool IsValid(object value)
        {
            DateTime dateTime;
            var isValid = DateTime.TryParseExact(Convert.ToString(value),
                "HH:mm",
                CultureInfo.CurrentCulture,
                DateTimeStyles.None,
                out dateTime);
            return isValid;
        }
    }
}