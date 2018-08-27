using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListarGenericas
{
    class Program
    {
        static void Main(string[] args)
        {

            //*******************************************************************************************
            //List<Int32> numerosImpares;

            //numerosImpares = new List<Int32>();

            //for (int i =  1; i  < 100; i = i+2)
            //{
            //    numerosImpares.Add(i);
            //}


            //foreach (var item in numerosImpares)
            //{
            //    Console.WriteLine(item);
               
            //}

            //Console.ReadKey();

            //**********************************************************************************************

            List<Int32> numerosImpares;

            numerosImpares = new List<Int32> {1, 3, 5, 7, 9, 11, 13, 15};

            //numerosImpares.Remove(5);
            //numerosImpares.RemoveAt(2);
            numerosImpares.RemoveAll(a => a >= 5);

            for (int i = 0; i < numerosImpares.Count(); i++)
            {
                Console.WriteLine(numerosImpares[i]);
            }

            

            //**********************************************************************************************

            //////List<int> numero = new List<int>();

            //////List<string> textos = new List<string>();

            //////List<Cliente> cliente = new List<Cliente>();


            //////numero.Add(4);
            
            //////numero.Add(3);
          
            //////numero.Add(1);
            //////numero.Add(2);

            //////textos.Add("jose");

            //Console.WriteLine(numero.Count());

            //textos.Remove("Beto");
            
            //Console.WriteLine(textos.Count());


            //////numero.Sort();

            //////foreach (var item in numero)
            //////{
            //////    Console.WriteLine(item);
            //////}

          

            Console.ReadKey();



        }
    }
}
