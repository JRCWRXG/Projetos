using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriacaoClasse
{
    class Pessoa
    {
        //***************************************************************************
        ////private string nome;
        ////private double altura;



        ////public void setNome(String valor)
        ////{
        ////    //nome = valor;
        ////    this.nome = valor;

        ////}

        ////public String getNome()
        ////{
        ////    return this.nome;
        ////}




        ////public void setAltura(double valores)
        ////{
        ////    //altura = valor;
        ////    this.altura = valores;

        ////}

        ////public double getaltura()
        ////{
        ////    return this.altura;
        ////}

        //***************************************************************************
       
        
        private string _nome;
        private double _altura;

        public string nome
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




        public Double altura
        {
            get
            {
                return this._altura;

            }

            set
            {
                this._altura = value;
            }

        }


        

        public void faleSobreVoce()
        {
            Console.WriteLine("Meu nome é " + nome);
            Console.WriteLine("Minha altura é " + altura);
        }
    }
}
