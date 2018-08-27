using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriacaoClasse
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Pessoa pessoa = new Pessoa();

            Console.WriteLine("Efetua a leitua de dados das pessoas");

            Console.Write("Informe seu nome");

            
           // pessoa.setNome(Console.ReadLine());
            pessoa.nome = Console.ReadLine();

            Console.Write("Informe sua altura");
            pessoa.altura = Convert.ToDouble(Console.ReadLine());
          //  pessoa.setAltura(Convert.ToDouble(Console.ReadLine()));

            pessoa.faleSobreVoce();

            Console.ReadKey();
        }
    }
}
