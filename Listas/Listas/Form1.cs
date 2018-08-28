using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Objects;
using System.Linq.Expressions;

namespace Listas
{
    public partial class Form1 : Form
    {
        PedidosDataContext ped = new PedidosDataContext();


        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //comboBox1.DataSource = (from p in ped.CLIENTEs
            //                        select p.NOME).ToList();
            //comboBox1.DisplayMember = "NOME";


            //var item = ped.CLIENTEs.Where(p => p.NOME == "ADALBERTO M. CABRAL").SingleOrDefault();
            //comboBox1.DataSource = item.NOME.ToList();
            //comboBox1.DisplayMember = "NOME";

            //var item = ped.CLIENTEs
            var item = (from p in ped.CLIENTEs
                        select p.NOME).ToList();
            comboBox1.DataSource = item.ToList();
            comboBox1.DisplayMember = "NOME";

            //https://sites.google.com/site/programacaoonline/family-blog/c/alimentar-dois-controles-combobox-com-linq-to-sql-em-c
        }

        private void button1_Click(object sender, EventArgs e)
        {


            var pedidos = from p in ped.PEDIDOs


                          select new
                          {
                              p.NUM_PEDIDO,
                              p.DATA_EMISSAO,
                              p.VLR_TOTAL,
                              p.SITUACAO

                          };
            pedidos.ToList();

            dataGridView1.DataSource = pedidos.ToList();
            label1.Text = pedidos.Count().ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var pedidos = from p in ped.PEDIDOs
                          orderby (p.DATA_EMISSAO)
                          where (p.DATA_EMISSAO >= new DateTime(2007, 1, 1) &&
                                 p.DATA_EMISSAO <= new DateTime(2007, 1, 31))

                          //  where p.DATA_EMISSAO.Year == 2007
                          select new
                          {
                              p.NUM_PEDIDO,
                              p.DATA_EMISSAO,
                              p.VLR_TOTAL,
                              p.SITUACAO

                          };
            pedidos.ToList();



            dataGridView1.DataSource = pedidos.ToList();
            ///label1.Text = pedidos.Count().ToString();

            // string strQuery = (pedidos as ObjectQuery).ToTraceString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var pedidos = from p in ped.PEDIDOs
                          join v in ped.VENDEDOREs on p.CODVEN equals v.CODVEN
                          orderby (p.DATA_EMISSAO)
                          where (p.DATA_EMISSAO >= new DateTime(2007, 1, 1) &&
                                p.DATA_EMISSAO <= new DateTime(2007, 1, 31))

                          select new

                          {
                              p.NUM_PEDIDO,
                              p.DATA_EMISSAO,
                              p.VLR_TOTAL,
                              p.SITUACAO,
                              v.NOME

                          };

            dataGridView1.DataSource = pedidos.ToList();
            label1.Text = pedidos.Count().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
