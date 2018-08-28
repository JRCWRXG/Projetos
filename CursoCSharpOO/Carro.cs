using System;
using System.Windows.Forms;

namespace CursoCSharpOO
{
    public class Carro: MeioTransporte
    {        
        public int Quilometragem;

        public override void Mover()

        {
            //chame o mover da classe base no caso meio de transporte
            base.Mover();


            MessageBox.Show(Descricao + " entrou em movimento.");

            //override sobresquever o metodo mover da classe base


        }
    }
}
