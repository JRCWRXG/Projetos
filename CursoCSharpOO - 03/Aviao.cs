using System;
using System.Windows.Forms;

namespace CursoCSharpOO
{
    public class Aviao : MeioTransporte
    {
        //public int Horas;

        private int _horas;

        public int Horas
        {
            get { return _horas; }
            set
            {
                if (value > 20)
                    throw new Exception("Avião muito antigo!");
                _horas = value;
            }
        }


        public Aviao()
        {
            Horas = 0;
        }


        protected override void Ligar()
        // public override void Ligar()
        {
            MessageBox.Show("Ligando " + Descricao);
        }


        public override void Mover()
        {
            base.Mover();
            MessageBox.Show(Descricao + " está voando.");
        }
    }
}
