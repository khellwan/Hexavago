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
    public partial class LoginRecepcionista : Form
    {
        public LoginRecepcionista()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textLogin.Text == "")
                MessageBox.Show("CPF inválido. ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (textSenha.Text == "")
                MessageBox.Show("Senha inválida. ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else //if (string.IsNullOrEmpty(BancoDados.efetuarLogin(textLogin.Text, textSenha.Text, "recepcionista")))
            {
                ServicosRecepcionista cf = new ServicosRecepcionista();
                cf.Show();
            }
            this.Close();
        }

        private void textLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginRecepcionista_Load(object sender, EventArgs e)
        {

        }
    }
}
