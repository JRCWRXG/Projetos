using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class PessoaFisica: Pessoa
    {
        private String _RG;
        private String _CPF;


        public PessoaFisica (string nome, string telefone, string email, string rg, String cpf):base(nome, telefone, email)
        {
            this.RG = rg;
            this.CPF = cpf;
        }



        public PessoaFisica(): base()
        {
            this.RG = "";
            this.CPF = "";

        }



        public String RG
        {
            get
            {
                return this._RG;

            }

            set
            {
                this._RG = value;
            }
        }



        public String CPF
        {
            get
            {
                return this._CPF;

            }

            set
            {
                this._CPF = value;
            }
        }

        public void ExibirDados()
        {
            Console.Clear();
            base.ExibirNome();
            Console.WriteLine("RG: " + this._RG);
            Console.WriteLine("CPF: " + this._CPF);
        }
    }
}
