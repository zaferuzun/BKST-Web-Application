using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.DataModel
{
    public class CountryData
    {
        [Display(Name = "Ülke Id")]
        public Guid ID_COUNTRY { get; set; }
        
        [Display(Name = "Ülke Adı")]
        public string COUNTRY_NAME { get; set; }

    }

}