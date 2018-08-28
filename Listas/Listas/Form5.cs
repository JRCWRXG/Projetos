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
    public partial class Form5 : Form
    {
        PedidosEntities pedidos = new PedidosEntities();
        public Form5()
        {
            InitializeComponent();
        }

        private void btnFiltra_Click(object sender, EventArgs e)
        {
            var clientes = from c in pedidos.CLIENTES
                           where c.NOME.Contains(tbxFiltraNome.Text) &&
                           c.ESTADO.StartsWith(tbxFiltraUF.Text)
                           orderby c.NOME
                           select new
                           {
                               c.CODCLI,
                               c.NOME,
                               c.FANTASIA,
                               c.ENDERECO,
                               c.BAIRRO,
                               c.CIDADE,
                               c.ESTADO,
                               c.CEP,
                               c.CNPJ,
                               c.INSCRICAO,
                               c.E_MAIL,
                               c.FONE1,
                               c.FAX
                           };

            bsClientes.DataSource = clientes.ToList();
            dgvClientes.DataSource = bsClientes;


        }

        private void Form5_Load(object sender, EventArgs e)
        {
            btnFiltra.PerformClick();

            tbxCODCLI.DataBindings.Add("Text", bsClientes, "CODCLI");
            tbxNOME.DataBindings.Add("Text", bsClientes, "NOME");
            tbxFANTASIA.DataBindings.Add("Text", bsClientes, "FANTASIA");
            tbxENDERECO.DataBindings.Add("Text", bsClientes, "ENDERECO");
            tbxBAIRRO.DataBindings.Add("Text", bsClientes, "BAIRRO");
            tbxCIDADE.DataBindings.Add("Text", bsClientes, "CIDADE");
            tbxESTADO.DataBindings.Add("Text", bsClientes, "ESTADO");
            tbxCEP.DataBindings.Add("Text", bsClientes, "CEP");
            tbxCNPJ.DataBindings.Add("Text", bsClientes, "CNPJ");
            tbxINSCRICAO.DataBindings.Add("Text", bsClientes, "INSCRICAO");
            tbxFONE1.DataBindings.Add("Text", bsClientes, "FONE1");
            tbxE_MAIL.DataBindings.Add("Text", bsClientes, "E_MAIL");
        }

        private void btnInclui_Click(object sender, EventArgs e)
        {
           
        }
    }
}
