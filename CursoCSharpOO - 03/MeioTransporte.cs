using System;
using System.Windows.Forms;


namespace CursoCSharpOO
{
    public abstract class MeioTransporte
    //public class MeioTransporte
    {
        //private string teste;
        protected string teste;

        //public string Descricao;

        private string _descricao;

         //public string Descricao {get; set;} ---propriedade automatica podendo usar assim ....
        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }


        //public int Capacidade;

        private int _capacidade;
        public int Capacidade
        {
            get { return _capacidade; }
            set { _capacidade = value; }
        }


        public MeioTransporte()
        {
            Descricao = "(indefinido)";
            teste = "oi";
        }

        protected abstract void Ligar();
        //  public abstract void ligar()
        //public virtual void ligar()



        public virtual void Mover()
        {
            Ligar();

            //   MessageBox.Show("Ligando meio de transporte:" + Descricao);


        }
    }
}
