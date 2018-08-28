using System;
using System.Windows.Forms;

namespace CursoCSharpOO
{
    public class Aviao: MeioTransporte
    {
        public int Horas;

        public override void Mover()
        {
            MessageBox.Show(Descricao + " está voando.");
        }
    }
}
