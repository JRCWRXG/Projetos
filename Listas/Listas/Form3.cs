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
    public partial class Form3 : Form
    {

        public DataTable dtt;



        private void criarDatatable()
        {
            // Cria o DataTable com a tabela
            dtt = new DataTable();

            // Cria as colunas 
            dtt.Columns.Add(new DataColumn("id", typeof(Int32)));
            dtt.Columns.Add(new DataColumn("estado", typeof(string)));
            dtt.Columns.Add(new DataColumn("area", typeof(Int32)));
            dtt.Columns.Add(new DataColumn("fator1", typeof(double)));
            dtt.Columns.Add(new DataColumn("fator2", typeof(double)));

            // Define a primeira coluna como chave primária da tabela
            dtt.PrimaryKey = new DataColumn[] { dtt.Columns["id"] };
        }




        private void inserirLinha(int pId, string pEstado, int pArea, double pFator1, double pFator2)
        {
            // Insere linhas com dados
            DataRow lin = dtt.NewRow();

            lin["id"] = pId;
            lin["estado"] = pEstado;
            lin["area"] = pArea;
            lin["fator1"] = pFator1;
            lin["fator2"] = pFator2;
            dtt.Rows.Add(lin);
        }

        private void atualizaTextBox()
        {
            int lin = Convert.ToInt32(comboBox1.SelectedIndex);

            textBox1.Text = dtt.Rows[lin]["area"].ToString();
            textBox2.Text = dtt.Rows[lin]["fator1"].ToString();
            textBox3.Text = dtt.Rows[lin]["fator2"].ToString();
        }


        private DataTable meudatatable()
        {

            DataTable dt = new DataTable();

            dt.Columns.Add("Name");
            dt.Columns.Add("Age");

            return dt;
        }


        public DataTable inserir()
        {
            DataTable dt = meudatatable();

            dt.Rows.Add("Beto", "22");
            dt.AcceptChanges();

            dataGridView1.DataSource = dt;

            return dt;
        }


        static string metodoqueretornostring(int idade)
        {
            if (idade > 18)
            {
                return "Adulto";

            }
            else if (idade <= 11)
                return "Criança";

            else

                return "Adolecente";

        }


        static bool metodoqueretornaboll(string valor)
        {

            if (valor == "Adulto")
            {
                return true;
            }

            return false;
        }


        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            ////https://www.youtube.com/watch?v=idyX6NaDM8A

            try
            {
                // Cria o DataTable
                criarDatatable();

                // Insere linha com dados no DataTable
                inserirLinha(1, "MG", 18, 2.3, 2.56);
                inserirLinha(2, "SP", 12, 5.3, 2.56);

                // Configura o comboBox 


                comboBox1.DataSource = dtt;
                comboBox1.DisplayMember = "estado";
                comboBox1.ValueMember = "id";
                comboBox1.SelectedIndex = 0;

                // Preenche os textBox pela primeira vez
                atualizaTextBox();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> MinhaLista = new List<string>();

             
            MinhaLista.Add("Beto");
            MinhaLista.Add("Lucas");
            MinhaLista.Add("Julia");
            MinhaLista.Add("Alice");

            //MinhaLista.Clear();

            MinhaLista.RemoveAt(0);

            int total = MinhaLista.Count;

            textBox1.Text += "Total de itens " + total + "\n";

            if (MinhaLista.Contains("Beto"))
            {
                textBox1.Text += "Beto esta na lista\n";
            }

            else
            {
                textBox1.Text += "Beto não esta na lista\n";
            }

            listBox1.DataSource = MinhaLista;

            textBox1.Text += "Posição Julia " + MinhaLista.IndexOf("Julia") + "\n";

            var MinhaLista1 = new List<string>();

            //foreach (var item in MinhaLista)
            //{
            //    MinhaLista1.Add(item);
            //}

            listBox2.DataSource = MinhaLista1;

            var Teste =
                from p in MinhaLista
                select p;

            foreach (var item in Teste)
            {
                MinhaLista1.Add(item);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int a = 2;
                int b = 0;
                int resultado = a / b;

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {


            List<string> nomes = new List<string>();

            nomes.Add("Beto");
            nomes.Add("Julia");
            nomes.Add("Luca");

            for (int i = 0; i < nomes.Count; i++)
            {
                listBox1.Items.Add(nomes[i]);
            }




            foreach (var item in nomes)
            {
                listBox2.Items.Add(item);
            }






            //https://www.youtube.com/watch?v=USUm7jSAmMM

            //int numero = 10;

            //while(numero > 0)
            //{
            //    listBox1.Items.Add(numero);
            //   // numero = numero - 1;
            //    //numero -= 1;
            //    numero--;
            //}

            int total = nomes.Count - 1;

            while (total >= 0)
            {
                listBox3.Items.Add(nomes[total]);

                if (total == 2)
                {
                    break;
                }
                total--;

            }


        }



        private void button6_Click(object sender, EventArgs e)
        {
            int lin = Convert.ToInt32(comboBox1.SelectedIndex);

            textBox1.Text = dtt.Rows[lin]["area"].ToString();
            textBox2.Text = dtt.Rows[lin]["fator1"].ToString();
            textBox3.Text = dtt.Rows[lin]["fator2"].ToString();
        }


        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            atualizaTextBox();


            //http://www.dotnetperls.com/datatable
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DataTable datatable = new DataTable();
            datatable.Clear();
            datatable.Columns.Add("Nome", typeof(string));
            datatable.Columns.Add("Idade", typeof(int));
            datatable.Columns.Add("Endereço", typeof(string));

            DataRow dr = datatable.NewRow();
            dr["Nome"] = "Beto";
            dr["Idade"] = "42";
            dr[2] = "R. Andrea Del Castagno 509";

            datatable.Rows.Add(dr);


            dataGridView1.DataSource = datatable;


            ////// Cria as colunas 
            ////dt.Columns.Add(new DataColumn("id", typeof(Int32)));
            ////dt.Columns.Add(new DataColumn("estado", typeof(string)));
            ////dt.Columns.Add(new DataColumn("area", typeof(Int32)));
            ////dt.Columns.Add(new DataColumn("fator1", typeof(double)));
            ////dt.Columns.Add(new DataColumn("fator2", typeof(double)));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("Name", typeof(string)));
            dt.Columns.Add(new DataColumn("Age", typeof(Int32)));

            DataRow dr = dt.NewRow();

            dr["Name"] = "Jose Roberto";
            dr["Age"] = 24;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Name"] = "Julia de Campos";
            dr["Age"] = 23;
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["Name"] = "Lucas de Campos";
            dr["Age"] = 42;
            dt.Rows.Add(dr);


            //  int intQtde = 0;
            string strnome = string.Empty;

            foreach (DataRow linha in dt.Rows)
            {
                //intQtde += Convert.ToInt16(linha[1]);
                strnome = Convert.ToString(linha[0]);
                if (linha[0].ToString() == "Jose")
                {
                    // MessageBox.Show("jose localizado");
                }
            }

            int l = dt.Rows.Count;
            for (int i = 0; i < (dt.Rows.Count); i++)
            {
                strnome = dt.Rows[i]["Name"].ToString();
                strnome = dt.Rows[i][0].ToString();
            }


            int b = 0;
            while (b < dt.Rows.Count)
            {
                //////int j = 0;
                //////string nome = "";
                //////while (j < dt.Columns.Count)
                //////{
                //////    nome += dt.Rows[b][j].ToString() + " --> ";
                //////    j++;
                //////}

                string nome = "";
                string idade = "";
                nome = dt.Rows[b][0].ToString();
                idade = dt.Rows[b][1].ToString();

                b++;
            }


            dataGridView1.DataSource = dt;
            //  dataGridView1.DataBind();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            inserir();


        }

        private void button10_Click(object sender, EventArgs e)
        {
            string resposta = metodoqueretornostring(21);
            //   resposta = resposta.ToUpper

            bool resposta1 = metodoqueretornaboll(resposta);



            //  texto = metodoextensivlequeTransformaPrimeiraletraEmMaiuscula(texto);



            //static string metodoextensivlequeTransformaPrimeiraletraEmMaiuscula(this string texto)
            //{
            //    string primeiraletra = texto[0].ToString().ToUpper();
            //    texto = primeiraletra + texto.Substring(1);
            //    return texto;
            //}


        }


    }
}


