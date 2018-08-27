using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo2
{
    class Triangulo
    {
        public int ladoA;
        public int ladoB;
        public int ladoC;



        public void VerificaTriangulo()
        {
            if ((ladoA < ladoB + ladoC) && (ladoB < ladoA + ladoC) && (ladoC < ladoB + ladoA))
            {
                Console.WriteLine("Forma um tringulo");

            }
            else
            {
                Console.WriteLine("não forma um tringulo");
            }

        }

    }
}
