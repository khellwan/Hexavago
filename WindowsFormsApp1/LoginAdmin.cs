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
    public partial class LoginAdmin : Form
    {
        public LoginAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textLogin.Text == "")
                MessageBox.Show("Login inválido. ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (textSenha.Text == "")
                MessageBox.Show("Senha inválida. ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                CadastrarFuncionario cf = new CadastrarFuncionario();
                cf.Show();
            }
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
