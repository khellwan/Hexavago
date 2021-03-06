﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class CadastrarFuncionario : Form
    {
        public CadastrarFuncionario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textNome.Text == "")
                MessageBox.Show("Insira o nome do funcionário a ser cadastrado. ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if (textCPF.Text == "")
                MessageBox.Show("Insira o CPF do funcionário a ser cadastrado. ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if (textCargo.Text == "")
                MessageBox.Show("Insira um cargo para o funcionário a ser cadastrado. ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if (textLogin.Text == "")
                MessageBox.Show("Insira uma senha para o funcionário a ser cadastrado. ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                //Funcionario f1 = new Funcionario(textNome.Text, textCPF.Text, textLogin.Text);
                BancoDados.criaFuncionario(textNome.Text, textCPF.Text, textLogin.Text, textSenha.Text, textCargo.Text);
                MessageBox.Show("Funcionario cadastrado com sucesso. ", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
