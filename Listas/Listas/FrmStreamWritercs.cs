using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Listas
{
    public partial class FrmStreamWritercs : Form
    {
        public FrmStreamWritercs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamReader Reader = new StreamReader(@"C:\Users\JRCWRXG\Desktop\Teste.txt"))

            {

                while (Reader.EndOfStream)
                {

                    textBox1.AppendText(Reader.ReadLine());
                }
            }
        }
    }
}
