using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizio_cane
{
    internal class Program
    {
        static void Main(string[] args)
        { Cane c = new Cane();
            c.nome = "Ringhio";
            c.razza = "Labrador";
           
            c.propietario = new Persona();
            c.propietario.nome = "Simone";
            Console.WriteLine("{0}", c.propietario.nome);


            Console.ReadLine();
        }
    }
}
