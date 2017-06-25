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
            this.checkboxReserva = new System.Windows.Forms.CheckBox();
            this.checkboxCancelar = new System.Windows.Forms.CheckBox();
            this.textLogincliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkboxCheckin = new System.Windows.Forms.CheckBox();
            this.checkboxCheckout = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textPessoas = new System.Windows.Forms.TextBox();
            this.textSaida = new System.Windows.Forms.TextBox();
            this.textEntrada = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textSenha = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textLogin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textCPF = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textSenhacliente = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkboxReserva
            // 
            this.checkboxReserva.AutoSize = true;
            this.checkboxReserva.Location = new System.Drawing.Point(37, 175);
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
            this.checkboxCancelar.Location = new System.Drawing.Point(108, 19);
            this.checkboxCancelar.Name = "checkboxCancelar";
            this.checkboxCancelar.Size = new System.Drawing.Size(111, 17);
            this.checkboxCancelar.TabIndex = 9;
            this.checkboxCancelar.Text = "Cancelar Reserva";
            this.checkboxCancelar.UseVisualStyleBackColor = true;
            this.checkboxCancelar.CheckedChanged += new System.EventHandler(this.checkboxCancelar_CheckedChanged);
            // 
            // textLogincliente
            // 
            this.textLogincliente.Enabled = false;
            this.textLogincliente.Location = new System.Drawing.Point(108, 65);
            this.textLogincliente.Name = "textLogincliente";
            this.textLogincliente.Size = new System.Drawing.Size(174, 20);
            this.textLogincliente.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Senha do cliente:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // checkboxCheckin
            // 
            this.checkboxCheckin.AutoSize = true;
            this.checkboxCheckin.Location = new System.Drawing.Point(456, 37);
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
            this.checkboxCheckout.Location = new System.Drawing.Point(358, 37);
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
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textPessoas);
            this.groupBox1.Controls.Add(this.textSaida);
            this.groupBox1.Controls.Add(this.textEntrada);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textSenha);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textLogin);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textNome);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textCPF);
            this.groupBox1.Controls.Add(this.checkboxReserva);
            this.groupBox1.Location = new System.Drawing.Point(40, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(652, 320);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reservar";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(281, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Nº de pessoas:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Data de saída:";
            // 
            // textPessoas
            // 
            this.textPessoas.Enabled = false;
            this.textPessoas.Location = new System.Drawing.Point(94, 250);
            this.textPessoas.Name = "textPessoas";
            this.textPessoas.Size = new System.Drawing.Size(93, 20);
            this.textPessoas.TabIndex = 34;
            // 
            // textSaida
            // 
            this.textSaida.Enabled = false;
            this.textSaida.Location = new System.Drawing.Point(94, 224);
            this.textSaida.Name = "textSaida";
            this.textSaida.Size = new System.Drawing.Size(93, 20);
            this.textSaida.TabIndex = 33;
            // 
            // textEntrada
            // 
            this.textEntrada.Enabled = false;
            this.textEntrada.Location = new System.Drawing.Point(94, 198);
            this.textEntrada.Name = "textEntrada";
            this.textEntrada.Size = new System.Drawing.Size(93, 20);
            this.textEntrada.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Data de entrada:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(257, 231);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Senha:";
            // 
            // textSenha
            // 
            this.textSenha.Enabled = false;
            this.textSenha.Location = new System.Drawing.Point(358, 227);
            this.textSenha.Name = "textSenha";
            this.textSenha.Size = new System.Drawing.Size(273, 20);
            this.textSenha.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(355, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Informações do Hóspede:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(257, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Login:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // textLogin
            // 
            this.textLogin.Enabled = false;
            this.textLogin.Location = new System.Drawing.Point(358, 179);
            this.textLogin.Name = "textLogin";
            this.textLogin.Size = new System.Drawing.Size(273, 20);
            this.textLogin.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(257, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Nome Completo:";
            // 
            // textNome
            // 
            this.textNome.Enabled = false;
            this.textNome.Location = new System.Drawing.Point(358, 86);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(273, 20);
            this.textNome.TabIndex = 24;
            this.textNome.TextChanged += new System.EventHandler(this.textNome_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(257, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "CPF do Cliente:";
            // 
            // textCPF
            // 
            this.textCPF.Enabled = false;
            this.textCPF.Location = new System.Drawing.Point(358, 130);
            this.textCPF.Name = "textCPF";
            this.textCPF.Size = new System.Drawing.Size(273, 20);
            this.textCPF.TabIndex = 25;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.textSenhacliente);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.checkboxCancelar);
            this.groupBox2.Controls.Add(this.textLogincliente);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.checkboxCheckin);
            this.groupBox2.Controls.Add(this.checkboxCheckout);
            this.groupBox2.Location = new System.Drawing.Point(40, 408);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(652, 167);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operações";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(281, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 33;
            this.button2.Text = "Enviar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "Login do cliente:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // textSenhacliente
            // 
            this.textSenhacliente.Enabled = false;
            this.textSenhacliente.Location = new System.Drawing.Point(108, 91);
            this.textSenhacliente.Name = "textSenhacliente";
            this.textSenhacliente.Size = new System.Drawing.Size(174, 20);
            this.textSenhacliente.TabIndex = 35;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(456, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 20);
            this.textBox1.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Numero do quarto:";
            // 
            // ServicosRecepcionista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 587);
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
        private System.Windows.Forms.CheckBox checkboxReserva;
        private System.Windows.Forms.CheckBox checkboxCancelar;
        private System.Windows.Forms.TextBox textLogincliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkboxCheckin;
        private System.Windows.Forms.CheckBox checkboxCheckout;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textLogin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textCPF;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textSenha;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textSaida;
        private System.Windows.Forms.TextBox textEntrada;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textPessoas;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textSenhacliente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}