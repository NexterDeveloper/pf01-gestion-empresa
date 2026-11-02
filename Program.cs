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
            Persona persona1 = new Persona("Ana", 25);
            persona1.MostrarDatos();
            persona1.SetNombre("Anabel");
            Console.WriteLine("Nombre modificado: " + persona1.GetNombre());
        }
    }
}
