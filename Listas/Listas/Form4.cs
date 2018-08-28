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
    public partial class Form4 : Form
    {
        PedidosEntities pedidos = new PedidosEntities();

        enum EditStatus { Consulta, Altera, Inclui };

        EditStatus recStatus;

        int codcli = 0;


        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var clientes = from c in pedidos.CLIENTES
                           where c.NOME.Contains(textBox1.Text) &&
                             c.ESTADO.StartsWith(textBox1.Text)
                           orderby c.NOME
                           select new

                           {
                             
                               //                   c.BAIRRO, c.CIDADE, c.ESTADO, c.CEP,
                               //                   c.CNPJ, c.INSCRICAO, c.E_MAIL, c.FONE1,
                               //                   c.FAX
                           };


            // var clientes = from c in pedidos.CLIENTES
            //               where c.NOME.Contains(tbxFiltraNome.Text) &&
            //                     c.ESTADO.StartsWith(tbxFiltraUF.Text)
            //               orderby c.NOME
            //               select new
            //               {
            //                   c.CODCLI, c.NOME, c.FANTASIA, c.ENDERECO,
            //                   c.BAIRRO, c.CIDADE, c.ESTADO, c.CEP,
            //                   c.CNPJ, c.INSCRICAO, c.E_MAIL, c.FONE1,
            //                   c.FAX
            //               };

            //bsClientes.DataSource = clientes.ToList();
            //dgvClientes.DataSource = bsClientes;
        }
    }
}
