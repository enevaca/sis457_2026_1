using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsola
{
    internal class Persona
    {
        public String cedulaIdentidad { get; set; }
        public String nombres { get; set; }
        public String primerApellido { get; set; }
        public String segundoApellido { get; set; }
        public DateOnly fechaNacimiento { get; set; }
        public long celular { get; set; }

        public virtual void saludar()
        {
            Console.WriteLine($"Soy {nombres} {primerApellido} y mi CI es {cedulaIdentidad}");
        }

        public int edad()
        {
            DateOnly fechaActual = DateOnly.FromDateTime(DateTime.Now);
            int edad = fechaActual.Year - fechaNacimiento.Year;
            if (fechaActual < fechaNacimiento.AddYears(edad)) edad--;
            return edad;
        }
    }
}
