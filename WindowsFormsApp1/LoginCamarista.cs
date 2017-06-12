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
    public partial class LoginCamarista : Form
    {
        public LoginCamarista()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textLogin.Text == "")
                MessageBox.Show("CPF inválido. ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (textSenha.Text == "")
                MessageBox.Show("Senha inválida. ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                ServicosCamarista cf = new ServicosCamarista();
                cf.Show();
            }
            this.Close();
        }
    }
}
