using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PS1._ChavezLopezEduardoGuillermo.Models
{
    public class City
    {
        public int Id { get; set; }
        public string NombreCiudad { get; set; }
        public int Poblacion { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
    }
}