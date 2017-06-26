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
    public partial class ServicosRecepcionista : Form
    {
        public ServicosRecepcionista()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ServicosRecepcionista_Load(object sender, EventArgs e)
        {
            textNumeroQuarto.Enabled = (checkboxCheckin.Checked || checkboxCancelar.Checked || checkboxCheckout.Checked);
            List<string> quartosVagos = BancoDados.carregaQuartosVagos();
            listQuartos.Items.AddRange(quartosVagos.ToArray());
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void checkboxReserva_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxReserva.Checked)
            {
                checkboxCancelar.Checked = false;
                checkboxCheckin.Checked = false;
                checkboxCheckout.Checked = false;
            }
            textNome.Enabled = checkboxReserva.Checked;
            textPessoas.Enabled = checkboxReserva.Checked;
            textLogin.Enabled = checkboxReserva.Checked;
            textSenha.Enabled = checkboxReserva.Checked;
            textSexo.Enabled = checkboxReserva.Checked;
            textCPF.Enabled = checkboxReserva.Checked;
            textEntrada.Enabled = checkboxReserva.Checked;
            textSaida.Enabled = checkboxReserva.Checked;
            textEmail.Enabled = checkboxReserva.Checked;
            textIdade.Enabled = checkboxReserva.Checked;
            textTelefone.Enabled = checkboxReserva.Checked;
            textEndereco.Enabled = checkboxReserva.Checked;
            textCEP.Enabled = checkboxReserva.Checked;
            textCidade.Enabled = checkboxReserva.Checked;
            textEstado.Enabled = checkboxReserva.Checked;
            listQuartos.Enabled = checkboxReserva.Checked;
        }

        private void checkboxCancelar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxCancelar.Checked)
            {
                checkboxReserva.Checked = false;
                checkboxCheckin.Checked = false;
                checkboxCheckout.Checked = false;
            }
            textNumeroQuarto.Enabled = (checkboxCheckin.Checked || checkboxCancelar.Checked || checkboxCheckout.Checked);
        }
        private void checkboxCheckin_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxCheckin.Checked)
            {
                checkboxCancelar.Checked = false;
                checkboxReserva.Checked = false;
                checkboxCheckout.Checked = false;
            }
            textNumeroQuarto.Enabled = (checkboxCheckin.Checked || checkboxCancelar.Checked || checkboxCheckout.Checked);
        }
        private void checkboxCheckout_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxCheckout.Checked)
            {
                checkboxCancelar.Checked = false;
                checkboxCheckin.Checked = false;
                checkboxReserva.Checked = false;
            }
            textNumeroQuarto.Enabled = (checkboxCheckin.Checked || checkboxCancelar.Checked || checkboxCheckout.Checked);
            textHospede.Enabled = checkboxCheckout.Checked;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkboxReserva.Checked)
                {
                    //Hospede h1 = new Hospede(textNome.Text, textCPF.Text, textAno.Text, textEmail.Text, Convert.ToInt32(textAno.Text))

                    Random rnd = new Random();
                    int id_reserva = rnd.Next(0, 2147483647);
                    //int id_reserva = 12345;
                    BancoDados.criaReserva(id_reserva.ToString(), textEntrada.Text, textSaida.Text, Convert.ToInt32(textPessoas.Text), Convert.ToInt32(listQuartos.SelectedItem));

                    BancoDados.criaHospede(id_reserva.ToString(), textNome.Text, textCPF.Text, textLogin.Text,  textSenha.Text, textSexo.Text, textEmail.Text, Convert.ToInt32(textIdade.Text), textTelefone.Text, textEndereco.Text, textCEP.Text, textCidade.Text, textEstado.Text);

                    MessageBox.Show("Reserva realizada!", "Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    List<string> quartosVagos = BancoDados.carregaQuartosVagos();
                    listQuartos.Items.AddRange(quartosVagos.ToArray());
                }
                else
                    MessageBox.Show("Existem campos obrigatórios não preenchidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string mensagem;
                mensagem = "OK!";
                if (checkboxCheckin.Checked)
                {
                    string quarto = BancoDados.checkIn(Int32.Parse(textNumeroQuarto.Text));
                    mensagem = "O hospede fez checkin no quarto " + quarto;
                    List<string> quartosVagos = BancoDados.carregaQuartosVagos();
                    listQuartos.Items.AddRange(quartosVagos.ToArray());
                }
                else if (checkboxCheckout.Checked)
                {
                    mensagem = "O hospede Fez checkout";
                    BancoDados.checkOut(Int32.Parse(textNumeroQuarto.Text));
                    List<string> quartosVagos = BancoDados.carregaQuartosVagos();
                    listQuartos.Items.AddRange(quartosVagos.ToArray());
                }
                else if (checkboxCancelar.Checked)
                {
                    BancoDados.deletaReserva(Int32.Parse(textNumeroQuarto.Text));
                    mensagem = "O hospede cancelou sua reserva";
                    List<string> quartosVagos = BancoDados.carregaQuartosVagos();
                    listQuartos.Items.AddRange(quartosVagos.ToArray());
                }
                else
                {
                    mensagem = "Clique em uma das opções";
                    List<string> quartosVagos = BancoDados.carregaQuartosVagos();
                    listQuartos.Items.AddRange(quartosVagos.ToArray());
                }
                textNumeroQuarto.Enabled = (checkboxCheckin.Checked || checkboxCancelar.Checked || checkboxCheckout.Checked);
                
                MessageBox.Show(mensagem, "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Número de quarto inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void listQuartos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }
    }
}
