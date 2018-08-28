using System;
using System.Windows.Forms;

namespace CursoCSharpOO
{
    public class Carro: MeioTransporte
    {        
        public int Quilometragem;

        public override void Mover()
        {
            MessageBox.Show(Descricao + " entrou em movimento.");
        }
    }
}
