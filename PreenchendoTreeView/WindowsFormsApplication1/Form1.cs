using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
       SqlConnection Conn = new SqlConnection("Data Source=.\\SQLExpress; Initial Catalog=DBOB203; Integrated Security=True");

        SqlDataReader rdr;

        SqlCommand cmd;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            Carregar();

        }




        private void Carregar()
        {

            lblItem.Text = "";

            cmd = new SqlCommand("Select id,nome,email,idade From CLIENTE Order By id", Conn);



            Conn.Open();

            rdr = cmd.ExecuteReader();

            TreeNode parent = treeView1.Nodes.Add("CLIENTE");



            TreeNode child;

            parent.ForeColor = Color.Red;



            while (rdr.Read())
            {

                child = parent.Nodes.Add("Aluno ID: " + rdr.GetValue(0).ToString());

                child.ForeColor = Color.Blue;

                child.Nodes.Add("Nome: " + rdr.GetValue(1).ToString());

                child.Nodes.Add("Email: " + rdr.GetValue(2).ToString());

                child.Nodes.Add("idade: " + rdr.GetValue(3).ToString());

            }

            parent.ExpandAll();



            rdr.Close();

            Conn.Close();

        }


        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

            int IDSelecionado = treeView1.SelectedNode.Index;

            String NomeSelecinado = treeView1.SelectedNode.Text;

            lblItem.Text = NomeSelecinado.ToString();

        }




        private void lnkRecolherItens_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblItem.Text = "";

            treeView1.CollapseAll();
        }






        private void btnCarga_Click(object sender, EventArgs e)
        {

            lblItem.Text = "";

            treeView1.Nodes.Clear();

            try
            {

                ConexaoDB cdb = new ConexaoDB();

                BLL negocio = new BLL();



                TreeNode parent = treeView1.Nodes.Add("Cliente");



                TreeNode child;

                parent.ForeColor = Color.Red;



                List<Aluno> _alunos = new List<Aluno>();

                _alunos = negocio.GetAlunosOB();


                foreach (Aluno _aluno in _alunos)
                {

                    child = parent.Nodes.Add("Aluno ID: " + _aluno.Id.ToString());

                    child.ForeColor = Color.Blue;

                    child.Nodes.Add("Nome: " + _aluno.Nome.ToString());

                    child.Nodes.Add("Email: " + _aluno.Email.ToString());

                    child.Nodes.Add("Idade: " + _aluno.Idade.ToString());

                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dataGridView1);

                    row.Cells[0].Value = _aluno.Id.ToString();
                    row.Cells[1].Value = _aluno.Nome.ToString();
                    row.Cells[2].Value = _aluno.Email.ToString();
                    row.Cells[3].Value = _aluno.Idade;
                    
                         dataGridView1.Rows.Add(row);

                    ////  dataGridView1.DataSource = _alunos;
                    //https://www.devmedia.com.br/listando-dados-no-gridview-c-net/23526
                }



                treeView1.ExpandAll();

            }

            catch (Exception ex)
            {

                MessageBox.Show("Erro : " + ex.Message);

            }

        }





    }
}
