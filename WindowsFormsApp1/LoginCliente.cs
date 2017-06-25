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
    public partial class LoginCliente : Form
    {
        public LoginCliente()
        {
            InitializeComponent();
        }

        private void LoginCliente_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textLogin.Text == "")
                MessageBox.Show("CPF inválido. ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (textSenha.Text == "")
                MessageBox.Show("Senha inválida. ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else //if (string.IsNullOrEmpty(BancoDados.efetuarLogin(textLogin.Text, textSenha.Text, "hospede")))
            {
                ServicosCliente cf = new ServicosCliente();
                cf.Show();
            }
            this.Close();
        }
    }
}
