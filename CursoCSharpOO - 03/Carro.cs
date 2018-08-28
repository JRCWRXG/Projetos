using System;
using System.Windows.Forms;

namespace CursoCSharpOO
{
    public class Carro : MeioTransporte
    {


        //public int Quilometragem;

        private int _quilometragem;
        public int Quilometragem
        {
            get { return _quilometragem; }
            set { _quilometragem = value; }
        }

        public Carro()
        {
            Quilometragem = 0;
            teste = "dsdsd";
        }


        protected override void Ligar()
        //public override void Ligar()
        {
            MessageBox.Show("Ligando " + Descricao);
        }

        public override void Mover()
        {
            base.Mover();
            MessageBox.Show(Descricao + " entrou em movimento.");
        }
    }
}
