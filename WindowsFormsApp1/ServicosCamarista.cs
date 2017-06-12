using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ServicosCamarista : Form
    {
        public ServicosCamarista()
        {
            InitializeComponent();
        }

        private void ServicosCamarista_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Quarto(s) marcado(s) como arrumado!", "Arrumado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Quarto(s) marcado(s) como atendidos!", "Arrumado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
