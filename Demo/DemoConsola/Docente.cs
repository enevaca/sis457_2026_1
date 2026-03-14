using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsola
{
    internal class Docente : Persona
    {
        public int item { get; set; }
        public override void saludar()
        {
            Console.WriteLine($"Soy {nombres} {primerApellido} y mi N° item es {item}");
        }
    }
}
