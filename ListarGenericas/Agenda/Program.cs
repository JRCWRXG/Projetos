using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Program
    {
        static void Main(string[] args)
        {

            ////Pessoa pessoa = new Pessoa();

            ////pessoa.nome = "Jose";
            ////pessoa.telefone = "1111-222";
            ////pessoa.email = "jose@fmail.com";


            //contrutor

          

            //////Pessoa pessoa = new Pessoa("jose", "222457", "jose@gmail.com");

            //////Pessoa pessoa1 = new Pessoa();

            //////pessoa1.nome = "jose";

            //////pessoa.ExibirNome();


            //////PessoaFisica pessofisica = new PessoaFisica();
            //////pessofisica.nome = "Jose";
            //////pessofisica.telefone = "44444";
            //////pessofisica.email = "sdds";
            //////pessofisica.RG = "222222";
            //////pessofisica.CPF = "1111";

            PessoaFisica pessofisica = new PessoaFisica("Julia", "11111", "dsdss", "20111", "5555");

            pessofisica.ExibirDados();


            Console.ReadKey();

        }
    }
}
