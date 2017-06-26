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
            this.checkboxCheckin = new System.Windows.Forms.CheckBox();
            this.checkboxCheckout = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textEstado = new System.Windows.Forms.TextBox();
            this.textCidade = new System.Windows.Forms.TextBox();
            this.textCEP = new System.Windows.Forms.TextBox();
            this.textEndereco = new System.Windows.Forms.TextBox();
            this.textTelefone = new System.Windows.Forms.TextBox();
            this.textIdade = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textSexo = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textSaida = new System.Windows.Forms.DateTimePicker();
            this.textEntrada = new System.Windows.Forms.DateTimePicker();
            this.listQuartos = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textPessoas = new System.Windows.Forms.TextBox();
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
            this.label1 = new System.Windows.Forms.Label();
            this.textNumeroQuarto = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.textHospede = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkboxReserva
            // 
            this.checkboxReserva.AutoSize = true;
            this.checkboxReserva.Location = new System.Drawing.Point(19, 24);
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
            this.checkboxCancelar.Location = new System.Drawing.Point(19, 37);
            this.checkboxCancelar.Name = "checkboxCancelar";
            this.checkboxCancelar.Size = new System.Drawing.Size(111, 17);
            this.checkboxCancelar.TabIndex = 9;
            this.checkboxCancelar.Text = "Cancelar Reserva";
            this.checkboxCancelar.UseVisualStyleBackColor = true;
            this.checkboxCancelar.CheckedChanged += new System.EventHandler(this.checkboxCancelar_CheckedChanged);
            // 
            // checkboxCheckin
            // 
            this.checkboxCheckin.AutoSize = true;
            this.checkboxCheckin.Location = new System.Drawing.Point(281, 37);
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
            this.checkboxCheckout.Location = new System.Drawing.Point(531, 37);
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
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.textEstado);
            this.groupBox1.Controls.Add(this.textCidade);
            this.groupBox1.Controls.Add(this.textCEP);
            this.groupBox1.Controls.Add(this.textEndereco);
            this.groupBox1.Controls.Add(this.textTelefone);
            this.groupBox1.Controls.Add(this.textIdade);
            this.groupBox1.Controls.Add(this.textEmail);
            this.groupBox1.Controls.Add(this.textSexo);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textSaida);
            this.groupBox1.Controls.Add(this.textEntrada);
            this.groupBox1.Controls.Add(this.listQuartos);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textPessoas);
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
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(466, 208);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(43, 13);
            this.label20.TabIndex = 58;
            this.label20.Text = "Estado:";
            // 
            // textEstado
            // 
            this.textEstado.Enabled = false;
            this.textEstado.Location = new System.Drawing.Point(520, 205);
            this.textEstado.Name = "textEstado";
            this.textEstado.Size = new System.Drawing.Size(120, 20);
            this.textEstado.TabIndex = 35;
            // 
            // textCidade
            // 
            this.textCidade.Enabled = false;
            this.textCidade.Location = new System.Drawing.Point(520, 173);
            this.textCidade.Name = "textCidade";
            this.textCidade.Size = new System.Drawing.Size(120, 20);
            this.textCidade.TabIndex = 34;
            // 
            // textCEP
            // 
            this.textCEP.Enabled = false;
            this.textCEP.Location = new System.Drawing.Point(520, 143);
            this.textCEP.Name = "textCEP";
            this.textCEP.Size = new System.Drawing.Size(120, 20);
            this.textCEP.TabIndex = 33;
            // 
            // textEndereco
            // 
            this.textEndereco.Enabled = false;
            this.textEndereco.Location = new System.Drawing.Point(520, 114);
            this.textEndereco.Name = "textEndereco";
            this.textEndereco.Size = new System.Drawing.Size(120, 20);
            this.textEndereco.TabIndex = 32;
            // 
            // textTelefone
            // 
            this.textTelefone.Enabled = false;
            this.textTelefone.Location = new System.Drawing.Point(520, 83);
            this.textTelefone.Name = "textTelefone";
            this.textTelefone.Size = new System.Drawing.Size(120, 20);
            this.textTelefone.TabIndex = 31;
            // 
            // textIdade
            // 
            this.textIdade.Enabled = false;
            this.textIdade.Location = new System.Drawing.Point(520, 51);
            this.textIdade.Name = "textIdade";
            this.textIdade.Size = new System.Drawing.Size(120, 20);
            this.textIdade.TabIndex = 30;
            // 
            // textEmail
            // 
            this.textEmail.Enabled = false;
            this.textEmail.Location = new System.Drawing.Point(340, 205);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(120, 20);
            this.textEmail.TabIndex = 29;
            // 
            // textSexo
            // 
            this.textSexo.Enabled = false;
            this.textSexo.Location = new System.Drawing.Point(340, 173);
            this.textSexo.Name = "textSexo";
            this.textSexo.Size = new System.Drawing.Size(120, 20);
            this.textSexo.TabIndex = 28;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(466, 146);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(31, 13);
            this.label19.TabIndex = 49;
            this.label19.Text = "CEP:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(466, 86);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 13);
            this.label18.TabIndex = 48;
            this.label18.Text = "Telefone:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(-473, -286);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 13);
            this.label17.TabIndex = 47;
            this.label17.Text = "Senha:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(249, 208);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 46;
            this.label16.Text = "Email:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(466, 176);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 45;
            this.label15.Text = "Cidade:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(466, 117);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 13);
            this.label14.TabIndex = 44;
            this.label14.Text = "Endereço:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(466, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 43;
            this.label13.Text = "Idade:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(249, 176);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 42;
            this.label12.Text = "Sexo:";
            // 
            // textSaida
            // 
            this.textSaida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.textSaida.Location = new System.Drawing.Point(109, 252);
            this.textSaida.Name = "textSaida";
            this.textSaida.Size = new System.Drawing.Size(113, 20);
            this.textSaida.TabIndex = 41;
            // 
            // textEntrada
            // 
            this.textEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.textEntrada.Location = new System.Drawing.Point(109, 225);
            this.textEntrada.Name = "textEntrada";
            this.textEntrada.Size = new System.Drawing.Size(113, 20);
            this.textEntrada.TabIndex = 40;
            // 
            // listQuartos
            // 
            this.listQuartos.FormattingEnabled = true;
            this.listQuartos.Location = new System.Drawing.Point(111, 86);
            this.listQuartos.Name = "listQuartos";
            this.listQuartos.Size = new System.Drawing.Size(96, 82);
            this.listQuartos.TabIndex = 39;
            this.listQuartos.SelectedIndexChanged += new System.EventHandler(this.listQuartos_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Selecione o quarto:";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(281, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Nº de pessoas:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Data de saída:";
            // 
            // textPessoas
            // 
            this.textPessoas.Enabled = false;
            this.textPessoas.Location = new System.Drawing.Point(109, 278);
            this.textPessoas.Name = "textPessoas";
            this.textPessoas.Size = new System.Drawing.Size(113, 20);
            this.textPessoas.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Data de entrada:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(249, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Senha:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // textSenha
            // 
            this.textSenha.Enabled = false;
            this.textSenha.Location = new System.Drawing.Point(340, 143);
            this.textSenha.Name = "textSenha";
            this.textSenha.Size = new System.Drawing.Size(120, 20);
            this.textSenha.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(249, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Informações do Hóspede:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(249, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Login:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // textLogin
            // 
            this.textLogin.Enabled = false;
            this.textLogin.Location = new System.Drawing.Point(340, 114);
            this.textLogin.Name = "textLogin";
            this.textLogin.Size = new System.Drawing.Size(120, 20);
            this.textLogin.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(249, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Nome Completo:";
            // 
            // textNome
            // 
            this.textNome.Enabled = false;
            this.textNome.Location = new System.Drawing.Point(340, 51);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(120, 20);
            this.textNome.TabIndex = 24;
            this.textNome.TextChanged += new System.EventHandler(this.textNome_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(249, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "CPF:";
            // 
            // textCPF
            // 
            this.textCPF.Enabled = false;
            this.textCPF.Location = new System.Drawing.Point(340, 83);
            this.textCPF.Name = "textCPF";
            this.textCPF.Size = new System.Drawing.Size(120, 20);
            this.textCPF.TabIndex = 25;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textHospede);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textNumeroQuarto);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.checkboxCancelar);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Numero do quarto:";
            // 
            // textNumeroQuarto
            // 
            this.textNumeroQuarto.Enabled = false;
            this.textNumeroQuarto.Location = new System.Drawing.Point(117, 83);
            this.textNumeroQuarto.Name = "textNumeroQuarto";
            this.textNumeroQuarto.Size = new System.Drawing.Size(174, 20);
            this.textNumeroQuarto.TabIndex = 59;
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
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(335, 86);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(91, 13);
            this.label21.TabIndex = 59;
            this.label21.Text = "CPF do Hóspede:";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // textHospede
            // 
            this.textHospede.Enabled = false;
            this.textHospede.Location = new System.Drawing.Point(432, 83);
            this.textHospede.Name = "textHospede";
            this.textHospede.Size = new System.Drawing.Size(174, 20);
            this.textHospede.TabIndex = 60;
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textPessoas;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNumeroQuarto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listQuartos;
        private System.Windows.Forms.DateTimePicker textSaida;
        private System.Windows.Forms.DateTimePicker textEntrada;
        private System.Windows.Forms.TextBox textCidade;
        private System.Windows.Forms.TextBox textCEP;
        private System.Windows.Forms.TextBox textEndereco;
        private System.Windows.Forms.TextBox textTelefone;
        private System.Windows.Forms.TextBox textIdade;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textSexo;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textEstado;
        private System.Windows.Forms.TextBox textHospede;
        private System.Windows.Forms.Label label21;
    }
}