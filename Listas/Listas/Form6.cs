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
    public partial class Form6 : Form
    {
        PedidosDataContext ped = new PedidosDataContext();
        Pessoas obj = new Pessoas();

        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {


            var consulta = from c in ped.TIPOPRODUTOs
                           orderby c.TIPO
                           select new
                           {
                               c.COD_TIPO,
                               c.TIPO
                           };
            consulta.ToList();


            comboBox1.DataSource = consulta.ToList();
            comboBox1.DisplayMember = "TIPO";
            comboBox1.ValueMember = "COD_TIPO";




        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int categoryID = 0;
            if (int.TryParse(comboBox1.SelectedValue.ToString(), out categoryID))
            {
                // using (NorthwindDataContext context = new NorthwindDataContext())
                {
                    var query = from p in ped.PRODUTOs
                                where p.COD_TIPO == categoryID
                                select new
                                {
                                    p.COD_TIPO,
                                    p.DESCRICAO
                                };

                    query.ToList();
                    comboBox2.DataSource = query.ToList();
                    comboBox2.DisplayMember = "DESCRICAO";
                    comboBox2.ValueMember = "COD_TIPO";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var consulta = (from o in ped.ITENSPEDIDOs
                            group o by new { o.NUM_PEDIDO, o.DATA_ENTREGA } into g

                            select new
                            {
                                NUM_PEDIDO = g.Key.NUM_PEDIDO,
                                Total = g.Sum(o => o.PR_UNITARIO),
                                data_entrega = g.Key.DATA_ENTREGA

                            }).Take(10);
            consulta.ToList();

            dataGridView1.DataSource = consulta.ToList();
            this.dataGridView1.Columns["Total"].DefaultCellStyle.Format = "c";
            this.dataGridView1.Columns["data_entrega"].DefaultCellStyle.Format = "d";
            //  http://www.codeproject.com/Articles/26657/Simple-LINQ-to-SQL-in-C

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var pesquisa = from c in ped.CLIENTEs
                           where c.NOME.StartsWith(comboBox3.Text)
                           orderby c.NOME ascending
                           select new
                           {
                               c.NOME,
                               c.ENDERECO
                           };
            pesquisa.ToList();

            dataGridView1.DataSource = pesquisa.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            // dataGridView1.DataSource = obj.SelecionaCategorias();

            dataGridView1.DataSource = obj.SelecionaCategorias().ToArray().Select(S => new { Nome = S.ToString() }).ToList();
            //  obj.SelecionaCategorias();
        }






        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = obj.Merda().Select(S => new { Usuario = S }).ToList();

        }






        private void button5_Click(object sender, EventArgs e)
        {
            //http://imasters.com.br/desenvolvimento/c-convertendo-um-datareader-para-uma-lista-generica-e-exibindo-em-um-treeview/?trace=1519021197&source=single
            dataGridView1.DataSource = obj.GetFoncedorOB();
        }








        private void button6_Click(object sender, EventArgs e)
        {
            var listaProdutos = new Pessoas().ConsultarProdutos();
            if (listaProdutos != null && listaProdutos.Count > 0)
            {
                this.dataGridView1.DataSource = listaProdutos;
                //  this.dataGridView1.Columns["PRECO_CUSTO"].DefaultCellStyle.Format = "c";
                // this.dataGridView1.Columns["PRECO_VENDA"].DefaultCellStyle.Format = "c";
                //  this.dataGridView1.Columns["data_entrega"].DefaultCellStyle.Format = "d";


                //    this.dataGridView1.DataBind();

            }

        }



        private void CarregarDetalhesProduto(int IdProduto)
        {
            var dadosProduto = new Pessoas().ConsultarProduto(IdProduto);
            if (dadosProduto != null)
            {
                this.txtProduto.Text = dadosProduto.ProductName;
                this.txtPrecoUnitario.Text = dadosProduto.UnitPrice.ToString();
                this.txtUnidadesEstoque.Text = dadosProduto.UnitsInStock.ToString();
            }
        }



        private void button7_Click(object sender, EventArgs e)
        {


            int ID;
            //  ID = int.Parse(txtID.Text);
            ID = Convert.ToInt32(txtID.Text);

            this.CarregarDetalhesProduto(ID);


            //http://www.devmedia.com.br/listando-dados-no-gridview-c-net/23526
        }
    }
}
