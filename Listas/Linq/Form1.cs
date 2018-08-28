using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Linq
{
    public partial class Form1 : Form
    {
        public class produto
        {
            public int Codigo;
            public string Nome;
            public double Preco;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] nums = new int[8];

            nums[0] = 0;
            nums[1] = 1;
            nums[2] = 1;
            nums[3] = 2;
            nums[4] = 3;
            nums[5] = 5;
            nums[6] = 8;
            nums[7] = 13;


            var query = from n in nums
                        where n % 2 == 0
                        select n;

            foreach (int x in query)


                listBox1.Items.Add(x);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var turma = new ArrayList();

            turma.Add("Beto");
            turma.Add("Viviane");
            turma.Add("Lucas");
            turma.Add("Julia");
            turma.Add("alice");


            foreach (var item in turma)
                listBox1.Items.Add(item);


            listBox1.Items.Add(turma[0]);
            listBox1.Items.Add("Capacidade: " + turma.Capacity);
            listBox1.Items.Add("Numero de elementos " + turma.Count);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var P1 = new produto() { Codigo = 1, Nome = "Beto", Preco = 1500 };
            var P2 = new produto() { Codigo = 2, Nome = "Julia", Preco = 1500 };
            var P3 = new produto() { Codigo = 3, Nome = "Lucas", Preco = 1500 };
            var P4 = new produto() { Codigo = 4, Nome = "viviane", Preco = 1500 };

            var carrinho = new List<produto>();

            carrinho.Add(P1);
            carrinho.Add(P2);
            carrinho.Add(P3);
            carrinho.Add(P4);
        }
    }
}
