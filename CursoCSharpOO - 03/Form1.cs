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
            //CarroObj = new Carro();
            //CarroObj.Descricao = tbDescricaoCarro.Text;
            //CarroObj.Capacidade = int.Parse(tbCapacidadeCarro.Text);
            //(CarroObj as Carro).Quilometragem = int.Parse(tbQuilometragemCarro.Text);

            //type cast convertendo CarroObj(meio de transporte) para carro


            CarroObj = new Carro()
            {
                Descricao = tbDescricaoCarro.Text,
                Capacidade = int.Parse(tbCapacidadeCarro.Text),
                Quilometragem = int.Parse(tbQuilometragemCarro.Text)

            };
        }

        private void btCriarAviao_Click(object sender, EventArgs e)
        {
            //AviaoObj = new Aviao();
            //AviaoObj.Descricao = tbDescricaoAviao.Text;
            //AviaoObj.Capacidade = int.Parse(tbCapacidadeAviao.Text);
            //(AviaoObj as Aviao).Horas = int.Parse(tbHorasAviao.Text);

            //objetoinitizlaiser
            try
            {

                AviaoObj = new Aviao()
                {
                    Descricao = tbDescricaoAviao.Text,
                    Capacidade = int.Parse(tbCapacidadeAviao.Text),
                    Horas = int.Parse(tbHorasAviao.Text)

                };


            }
            catch (Exception E)
            {
                MessageBox.Show("Erro ao criar aviao: " + E.Message);
            }
        }

        private void btnMoverCarro_Click(object sender, EventArgs e)
        {
            CarroObj.Mover();
            //   CarroObj.teste = "merda";
        }

        private void btnMoverAviao_Click(object sender, EventArgs e)
        {
            AviaoObj.Mover();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            CarroObj = new Carro()
            {
                Descricao = tbDescricaoCarro.Text,
                Capacidade = int.Parse(tbCapacidadeCarro.Text),
                Quilometragem = int.Parse(tbQuilometragemCarro.Text)

            };

            AviaoObj = new Aviao()
            {
                Descricao = tbDescricaoAviao.Text,
                Capacidade = int.Parse(tbCapacidadeAviao.Text),
                Horas = int.Parse(tbHorasAviao.Text)

            };

            var objPessoa = new Pessoa() { Nome = "José" };
            
            objPessoa.Transporte = CarroObj;
            objPessoa.Transporte.Mover();

            objPessoa.Transporte = AviaoObj;
            objPessoa.Transporte.Mover();

        }
    }
}
