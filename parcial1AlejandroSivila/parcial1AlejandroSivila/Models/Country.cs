using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace parcial1AlejandroSivila.Models
{
    public enum lugares { 
        Oriente_medio,
        Occidente,
        Oriente,
        Oceanía,
        Bolivia

    }
    public class Country
    {
        [Key]
        [StringLength(3, ErrorMessage = "solo las tres primeras letras")]
        public string Alpha3Code { get; set; }
        public lugares region { get; set; }
        [StringLength(30, ErrorMessage = "tiene que ser de entre los 5 lugares"), MinLength(3)]
        public string Name { get; set; }
        [Display(Name ="el area al que pertenece es:")]
        public int Area { get; set; }
        public int CallingCodes { get; set; }
        public string Languages { get; set; }
        public string Flag { get; set; }
    }
}