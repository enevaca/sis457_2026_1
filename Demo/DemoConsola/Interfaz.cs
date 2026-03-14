using System;
using System.Collections.Generic;
using System.Text;

namespace DemoConsola
{
    internal interface IVehiculo
    {
        void acelerar(int kmh);
        void frenar();
        void girar(int angulo);
    }

    internal class Automovil : IVehiculo
    {
        public void acelerar(int kmh)
        {
            Console.WriteLine($"Acelerando a {kmh} km/h...");
        }

        public void frenar()
        {
            Console.WriteLine("Frenando...");
        }

        public void girar(int angulo)
        {
            Console.WriteLine($"Girando {angulo} grados...");
        }
    }
}
