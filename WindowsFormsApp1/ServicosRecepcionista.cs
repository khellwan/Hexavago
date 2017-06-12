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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ServicosRecepcionista_Load(object sender, EventArgs e)
        {
            textCli.Enabled = (checkboxCheckin.Checked || checkboxCancelar.Checked || checkboxCheckout.Checked);
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
            checkedListBox1.Enabled = checkboxReserva.Checked;
            textNome.Enabled = checkboxReserva.Checked;
            textAno.Enabled = checkboxReserva.Checked;
            textEmail.Enabled = checkboxReserva.Checked;
            textCPF.Enabled = checkboxReserva.Checked;
        }

        private void checkboxCancelar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxCancelar.Checked)
            {
                checkboxReserva.Checked = false;
                checkboxCheckin.Checked = false;
                checkboxCheckout.Checked = false;
            }
            textCli.Enabled = (checkboxCheckin.Checked || checkboxCancelar.Checked || checkboxCheckout.Checked);
        }
        private void checkboxCheckin_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxCheckin.Checked)
            {
                checkboxCancelar.Checked = false;
                checkboxReserva.Checked = false;
                checkboxCheckout.Checked = false;
            }
            textCli.Enabled = (checkboxCheckin.Checked || checkboxCancelar.Checked || checkboxCheckout.Checked);
        }
        private void checkboxCheckout_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxCheckout.Checked)
            {
                checkboxCancelar.Checked = false;
                checkboxCheckin.Checked = false;
                checkboxReserva.Checked = false;
            }
            textCli.Enabled = (checkboxCheckin.Checked || checkboxCancelar.Checked || checkboxCheckout.Checked);
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if ((checkboxReserva.Checked) && (checkedListBox1.CheckedItems.Count > 0))
                {
                    Hospede h1 = new Hospede(textNome.Text, textCPF.Text, textAno.Text, textEmail.Text, Convert.ToInt32(textAno.Text));
                    MessageBox.Show("Reserva realizada!", "Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if ((checkboxCancelar.Checked) && (textCli.Text != ""))
                    MessageBox.Show("Cancelamento realizado!", "Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if ((checkboxCheckin.Checked) && (textCli.Text != ""))
                    MessageBox.Show("Check-in realizado!", "Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if ((checkboxCheckout.Checked) && (textCli.Text != ""))
                    MessageBox.Show("Check-out realizado!", "Pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Existem campos incompletos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
