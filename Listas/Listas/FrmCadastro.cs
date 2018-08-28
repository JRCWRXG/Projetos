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
    public partial class FrmCadastro : Form


    {
        int CodCli = 0;
        PedidosDataContext ped = new PedidosDataContext();
        public FrmCadastro()
        {
            InitializeComponent();
          
        }

        private void FrmCadastro_Load(object sender, EventArgs e)
        {
           
        }

        private void pesquisarButton_Click(object sender, EventArgs e)
        {
            int total;
           
            try
            {
                var Pesquisa = from c in ped.CLIENTEs
                               //where c.CNPJ.Contains(TXTCNPJ.Text)
                               where c.CNPJ.Equals(TXTCNPJ.Text)

                               select new
                               {
                                   c.CODCLI,
                                   c.NOME,
                                   c.ENDERECO,
                                   c.BAIRRO,
                                   c.E_MAIL,
                                   c.DATA_CAD

                               };
                Pesquisa.ToList();

                total = Pesquisa.Count();




                if (Pesquisa != null)
                {
                    foreach (var values in Pesquisa)
                    {
                        TXTCODCLI.Text = Convert.ToString(values.CODCLI);
                        TXTNOME.Text = values.NOME;
                        TXTENDERECO.Text = values.ENDERECO;
                        TXTBAIRRO.Text = values.BAIRRO;
                        TXTE_MAIL.Text = values.E_MAIL;
                        TXTDATA_CAD.Text = Convert.ToString(values.DATA_CAD);
                    }
                }

                else
                {
                    // throw new Exception("Código não localizado!");
                    MessageBox.Show("Pesquisa não localizado!");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void insereirButton_Click(object sender, EventArgs e)
        {

            try
            {
                CLIENTE cliente = new CLIENTE();

                cliente.NOME = (TXTNOME.Text).ToUpper();
                cliente.ENDERECO = (TXTENDERECO.Text).ToUpper();
                cliente.BAIRRO = (TXTBAIRRO.Text).ToUpper();
                cliente.E_MAIL = (TXTE_MAIL.Text);
                cliente.DATA_CAD = Convert.ToDateTime(TXTDATA_CAD.Text);


                ped.CLIENTEs.InsertOnSubmit(cliente);
                  ped.SubmitChanges();

                  MessageBox.Show("Gravado com sucesso!");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExcluirButton_Click(object sender, EventArgs e)
        {
            try
                
            {
                CodCli = Convert.ToInt32(TXTCODCLI.Text);
                var Pesquisa = (from c in ped.CLIENTEs
                                where c.CODCLI == CodCli

                                select c).ToList()[0];



                ped.CLIENTEs.DeleteOnSubmit(Pesquisa);
                ped.SubmitChanges();

                MessageBox.Show("Excluido com sucesso!");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void alterarButton_Click(object sender, EventArgs e)
        {
            try
            {
                 CodCli = Convert.ToInt32(TXTCODCLI.Text);

                 CLIENTE cliente = ped.CLIENTEs.Single(course => course.CODCLI == CodCli);

                //CLIENTE cliente = new CLIENTE();
               
                //var Pesquisa = (from c in ped.CLIENTEs
                //                where c.CODCLI == CodCli

                //                select c).ToList()[0];

                cliente.NOME = (TXTNOME.Text).ToUpper();
                cliente.ENDERECO = (TXTENDERECO.Text).ToUpper();
                cliente.BAIRRO = (TXTBAIRRO.Text).ToUpper();
                cliente.CNPJ = TXTCNPJ.Text;
                cliente.E_MAIL = (TXTE_MAIL.Text);
                cliente.DATA_CAD = Convert.ToDateTime(TXTDATA_CAD.Text);
                                             
                ped.SubmitChanges();

                MessageBox.Show("Alterado com sucesso!");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int idade = 50;
            string resultado = idade > 50 ? "Maior que 50" : "Menor que 50";

            // seleciona idade > 50 clica com direito e quick whatch

            MessageBox.Show(resultado + "");

            //https://www.youtube.com/watch?v=bINL5DjmxNk&ebc=ANyPxKoFn6yWA6V7eQjrf-27WhUIWXUY3vyZxxPNc81K_uzVM4LGcod6eljUa4dw8_mTUaEYKwFWpjdl66_pZa5JE2niSQwSzA
        }
    }
}
