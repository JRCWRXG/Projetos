using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo = new Triangulo();

            Console.Write("Informe lado A");
            triangulo.ladoA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe lado B");
            triangulo.ladoB = Convert.ToInt32(Console.ReadLine());

            Console.Write("Informe lado C");
            triangulo.ladoC = Convert.ToInt32(Console.ReadLine());

            triangulo.VerificaTriangulo();


            Console.ReadKey();

        }
    }
}
