namespace WindowsFormsApp1
{
    partial class ServicosRecepcionista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkboxReserva = new System.Windows.Forms.CheckBox();
            this.checkboxCancelar = new System.Windows.Forms.CheckBox();
            this.textCli = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkboxCheckin = new System.Windows.Forms.CheckBox();
            this.checkboxCheckout = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textAno = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textCPF = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Enabled = false;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "102",
            "105",
            "106",
            "201",
            "204",
            "207",
            "301",
            "308"});
            this.checkedListBox1.Location = new System.Drawing.Point(6, 59);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(183, 124);
            this.checkedListBox1.Sorted = true;
            this.checkedListBox1.TabIndex = 5;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Quartos Vagos:";
            // 
            // checkboxReserva
            // 
            this.checkboxReserva.AutoSize = true;
            this.checkboxReserva.Location = new System.Drawing.Point(6, 23);
            this.checkboxReserva.Name = "checkboxReserva";
            this.checkboxReserva.Size = new System.Drawing.Size(95, 17);
            this.checkboxReserva.TabIndex = 6;
            this.checkboxReserva.Text = "Fazer Reserva";
            this.checkboxReserva.UseVisualStyleBackColor = true;
            this.checkboxReserva.CheckedChanged += new System.EventHandler(this.checkboxReserva_CheckedChanged);
            // 
            // checkboxCancelar
            // 
            this.checkboxCancelar.AutoSize = true;
            this.checkboxCancelar.Location = new System.Drawing.Point(31, 17);
            this.checkboxCancelar.Name = "checkboxCancelar";
            this.checkboxCancelar.Size = new System.Drawing.Size(111, 17);
            this.checkboxCancelar.TabIndex = 9;
            this.checkboxCancelar.Text = "Cancelar Reserva";
            this.checkboxCancelar.UseVisualStyleBackColor = true;
            this.checkboxCancelar.CheckedChanged += new System.EventHandler(this.checkboxCancelar_CheckedChanged);
            // 
            // textCli
            // 
            this.textCli.Enabled = false;
            this.textCli.Location = new System.Drawing.Point(119, 91);
            this.textCli.Name = "textCli";
            this.textCli.Size = new System.Drawing.Size(100, 20);
            this.textCli.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "CPF do Cliente:";
            // 
            // checkboxCheckin
            // 
            this.checkboxCheckin.AutoSize = true;
            this.checkboxCheckin.Location = new System.Drawing.Point(31, 40);
            this.checkboxCheckin.Name = "checkboxCheckin";
            this.checkboxCheckin.Size = new System.Drawing.Size(68, 17);
            this.checkboxCheckin.TabIndex = 14;
            this.checkboxCheckin.Text = "Check-in";
            this.checkboxCheckin.UseVisualStyleBackColor = true;
            this.checkboxCheckin.CheckedChanged += new System.EventHandler(this.checkboxCheckin_CheckedChanged);
            // 
            // checkboxCheckout
            // 
            this.checkboxCheckout.AutoSize = true;
            this.checkboxCheckout.Location = new System.Drawing.Point(31, 63);
            this.checkboxCheckout.Name = "checkboxCheckout";
            this.checkboxCheckout.Size = new System.Drawing.Size(75, 17);
            this.checkboxCheckout.TabIndex = 17;
            this.checkboxCheckout.Text = "Check-out";
            this.checkboxCheckout.UseVisualStyleBackColor = true;
            this.checkboxCheckout.CheckedChanged += new System.EventHandler(this.checkboxCheckout_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label6.Location = new System.Drawing.Point(306, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 29);
            this.label6.TabIndex = 20;
            this.label6.Text = "Reservas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textEmail);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textAno);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textNome);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.checkedListBox1);
            this.groupBox1.Controls.Add(this.textCPF);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checkboxReserva);
            this.groupBox1.Location = new System.Drawing.Point(40, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(652, 242);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reservar";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(240, 166);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Email:";
            // 
            // textEmail
            // 
            this.textEmail.Enabled = false;
            this.textEmail.Location = new System.Drawing.Point(358, 163);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(273, 20);
            this.textEmail.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(355, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Informações do Hóspede:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(240, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Ano de Nascimento:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // textAno
            // 
            this.textAno.Enabled = false;
            this.textAno.Location = new System.Drawing.Point(358, 126);
            this.textAno.Name = "textAno";
            this.textAno.Size = new System.Drawing.Size(273, 20);
            this.textAno.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(240, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Nome Completo:";
            // 
            // textNome
            // 
            this.textNome.Enabled = false;
            this.textNome.Location = new System.Drawing.Point(358, 59);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(273, 20);
            this.textNome.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(240, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "CPF do Cliente:";
            // 
            // textCPF
            // 
            this.textCPF.Enabled = false;
            this.textCPF.Location = new System.Drawing.Point(358, 90);
            this.textCPF.Name = "textCPF";
            this.textCPF.Size = new System.Drawing.Size(273, 20);
            this.textCPF.TabIndex = 22;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkboxCancelar);
            this.groupBox2.Controls.Add(this.textCli);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.checkboxCheckin);
            this.groupBox2.Controls.Add(this.checkboxCheckout);
            this.groupBox2.Location = new System.Drawing.Point(40, 339);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 153);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cancelar";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(323, 540);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ServicosRecepcionista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 587);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "ServicosRecepcionista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ServicosRecepcionista";
            this.Load += new System.EventHandler(this.ServicosRecepcionista_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkboxReserva;
        private System.Windows.Forms.CheckBox checkboxCancelar;
        private System.Windows.Forms.TextBox textCli;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkboxCheckin;
        private System.Windows.Forms.CheckBox checkboxCheckout;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textAno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textCPF;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
    }
}