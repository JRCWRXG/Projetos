using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    public class Pessoa
    {

        protected String _nome;
        protected String _email;
        protected String _telefone;

        //criando contrutor

        public Pessoa(string nome, string telefone, string email)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.email = email;

        }


        //construtor com sobrecarga
        public Pessoa()
        {
            this.nome = "";
            this.telefone = "";
            this.email = "";

        }


        public String nome
        {
            get
            {
                return this._nome;

            }

            set
            {
                this._nome = value;
            }
        }


        public String email
        {
            get
            {
                return this._email;

            }

            set
            {
                this._email = value;
            }
        }




        public String telefone
        {
            get
            {
                return this._telefone;

            }

            set
            {
                this._telefone = value;
            }
        }


        public void ExibirNome()
        {
            Console.Clear();
            Console.WriteLine("Nome: " + this._nome);
            Console.WriteLine("email: " + this._email);
            Console.WriteLine("Telefone: " + this._telefone);
        }

    }
}
