using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PS1._ChavezLopezEduardoGuillermo.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string NombreEvento { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }
        public string TipoEvento { get; set; }
        public string Capacidad { get; set; }
        public City IdCiudad { get; set; }
    }
}