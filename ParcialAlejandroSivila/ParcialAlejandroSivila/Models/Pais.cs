using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ParcialAlejandroSivila.Models
{
    public enum Regiones { 
        España,
        China,
        Japon,
        Australia,
        Bolivia
    }
    public class Pais
    {
        [Key]
        [StringLength(3, ErrorMessage = "es necesario aclarar las tres primeras letras")]
        public string Alpha3Code { get; set; }
        public Regiones Region { get; set; }
        [StringLength(20, ErrorMessage = "es necesario que aclare el nombre los paises"), MinLength(5)]
        public string name { get; set; }
        public int area { get; set; }
        public int callingCodes { get; set; }
        public string languages { get; set; }
        public string flag { get; set; }
    }

}