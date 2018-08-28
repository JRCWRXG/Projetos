using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Pessoas p = new Pessoas();

            p.EstadoCivil = EstadoCivil.Solteiro;
            p.Sexo = Sexo.Feminino;
            p.Validate();

            EstadoCivil estado = EstadoCivil.Solteiro;
            MessageBox.Show("", "" +  (int)estado, MessageBoxButtons.OK);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListarPontos();
        }

        static void ListarPontos()
        {
            Pessoas p = new Pessoas();
            EstadoCivil ponto = EstadoCivil.Solteiro;

            for (int i = 0; i < 3; i++)
            {
                MessageBox.Show("", "Estado: " + ponto, MessageBoxButtons.OK);
                ponto++;

                //https://www.youtube.com/watch?v=Onv543gXiXc
            }
        }
    }
}
