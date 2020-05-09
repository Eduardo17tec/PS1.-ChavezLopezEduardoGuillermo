using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PS1._ChavezLopezEduardoGuillermo.Models
{
    public class EventDbContext:DbContext
    {
        public EventDbContext():base("ConexionPS1")
        {

        }
        public DbSet<Event> Events { get; set; }
        public DbSet<City> Cities { get; set; }
    }
}