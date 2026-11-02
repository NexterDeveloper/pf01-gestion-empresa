using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEmpresa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona2 = new Persona("Luis", 16);
            persona2.MostrarDatos();
            if (persona2.EsMayorDeEdad())
                Console.WriteLine("Es mayor de edad");
            else
                Console.WriteLine("Es menor de edad");
        }
    }
}
