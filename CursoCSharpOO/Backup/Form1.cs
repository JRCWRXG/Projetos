using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CursoCSharpOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // variavel do tipo Carro
        private MeioTransporte CarroObj;

        // variavel do tipo Aviao
        private MeioTransporte AviaoObj;

        private void btCriarCarro_Click(object sender, EventArgs e)
        {
            CarroObj = new Carro();
            CarroObj.Descricao = tbDescricaoCarro.Text;
            CarroObj.Capacidade = int.Parse(tbCapacidadeCarro.Text);
            (CarroObj as Carro).Quilometragem = int.Parse(tbQuilometragemCarro.Text);            
        }

        private void btCriarAviao_Click(object sender, EventArgs e)
        {
            AviaoObj = new Aviao();
            AviaoObj.Descricao = tbDescricaoAviao.Text;
            AviaoObj.Capacidade = int.Parse(tbCapacidadeAviao.Text);
            (AviaoObj as Aviao).Horas = int.Parse(tbHorasAviao.Text);
        }

        private void btnMoverCarro_Click(object sender, EventArgs e)
        {
            CarroObj.Mover();            
        }

        private void btnMoverAviao_Click(object sender, EventArgs e)
        {
            AviaoObj.Mover();

        }
    }
}
