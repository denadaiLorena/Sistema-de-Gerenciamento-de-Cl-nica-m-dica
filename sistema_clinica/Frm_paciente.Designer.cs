namespace Aplicacao_CRUD
{
    partial class Frm_paciente
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
            this.Txt = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Mtb_data = new System.Windows.Forms.MaskedTextBox();
            this.Txt_email = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Rbt_masculino = new System.Windows.Forms.RadioButton();
            this.Rbt_feminino = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.Mtb_celular = new System.Windows.Forms.MaskedTextBox();
            this.Txt_nome = new System.Windows.Forms.TextBox();
            this.Txt_id_paciente = new System.Windows.Forms.TextBox();
            this.Mtb_cpf = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Btn_cadastrar = new System.Windows.Forms.Button();
            this.Btn_alterar = new System.Windows.Forms.Button();
            this.Btn_limpar = new System.Windows.Forms.Button();
            this.Btn_excluir = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Btn_ok = new System.Windows.Forms.Button();
            this.Txt_filtro = new System.Windows.Forms.TextBox();
            this.Dtv_paciente = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dtv_paciente)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt
            // 
            this.Txt.AutoSize = true;
            this.Txt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt.Location = new System.Drawing.Point(11, 11);
            this.Txt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Txt.Name = "Txt";
            this.Txt.Size = new System.Drawing.Size(298, 32);
            this.Txt.TabIndex = 0;
            this.Txt.Text = "Cadastro de Paciente";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Mtb_data);
            this.groupBox1.Controls.Add(this.Txt_email);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.Mtb_celular);
            this.groupBox1.Controls.Add(this.Txt_nome);
            this.groupBox1.Controls.Add(this.Txt_id_paciente);
            this.groupBox1.Controls.Add(this.Mtb_cpf);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(63, 47);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1380, 200);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DADOS PESSOAIS";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Mtb_data
            // 
            this.Mtb_data.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mtb_data.Location = new System.Drawing.Point(204, 90);
            this.Mtb_data.Margin = new System.Windows.Forms.Padding(4);
            this.Mtb_data.Mask = "00/00/0000";
            this.Mtb_data.Name = "Mtb_data";
            this.Mtb_data.Size = new System.Drawing.Size(159, 35);
            this.Mtb_data.TabIndex = 15;
            this.Mtb_data.ValidatingType = typeof(System.DateTime);
            // 
            // Txt_email
            // 
            this.Txt_email.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_email.Location = new System.Drawing.Point(655, 157);
            this.Txt_email.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_email.Name = "Txt_email";
            this.Txt_email.Size = new System.Drawing.Size(560, 28);
            this.Txt_email.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox2.Controls.Add(this.Rbt_masculino);
            this.groupBox2.Controls.Add(this.Rbt_feminino);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(522, 59);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(305, 90);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // Rbt_masculino
            // 
            this.Rbt_masculino.AutoSize = true;
            this.Rbt_masculino.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbt_masculino.Location = new System.Drawing.Point(122, 48);
            this.Rbt_masculino.Margin = new System.Windows.Forms.Padding(4);
            this.Rbt_masculino.Name = "Rbt_masculino";
            this.Rbt_masculino.Size = new System.Drawing.Size(121, 25);
            this.Rbt_masculino.TabIndex = 12;
            this.Rbt_masculino.TabStop = true;
            this.Rbt_masculino.Text = "Masculino";
            this.Rbt_masculino.UseVisualStyleBackColor = true;
            this.Rbt_masculino.CheckedChanged += new System.EventHandler(this.Rbt_masculino_CheckedChanged_1);
            // 
            // Rbt_feminino
            // 
            this.Rbt_feminino.AutoSize = true;
            this.Rbt_feminino.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbt_feminino.Location = new System.Drawing.Point(122, 16);
            this.Rbt_feminino.Margin = new System.Windows.Forms.Padding(4);
            this.Rbt_feminino.Name = "Rbt_feminino";
            this.Rbt_feminino.Size = new System.Drawing.Size(112, 25);
            this.Rbt_feminino.TabIndex = 11;
            this.Rbt_feminino.TabStop = true;
            this.Rbt_feminino.Text = "Feminino";
            this.Rbt_feminino.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(60, 31);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sexo:";
            // 
            // Mtb_celular
            // 
            this.Mtb_celular.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mtb_celular.Location = new System.Drawing.Point(204, 151);
            this.Mtb_celular.Margin = new System.Windows.Forms.Padding(4);
            this.Mtb_celular.Mask = "(999) 0000-00000";
            this.Mtb_celular.Name = "Mtb_celular";
            this.Mtb_celular.Size = new System.Drawing.Size(270, 35);
            this.Mtb_celular.TabIndex = 10;
            // 
            // Txt_nome
            // 
            this.Txt_nome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nome.Location = new System.Drawing.Point(655, 23);
            this.Txt_nome.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_nome.Name = "Txt_nome";
            this.Txt_nome.Size = new System.Drawing.Size(703, 28);
            this.Txt_nome.TabIndex = 9;
            // 
            // Txt_id_paciente
            // 
            this.Txt_id_paciente.Enabled = false;
            this.Txt_id_paciente.Location = new System.Drawing.Point(204, 21);
            this.Txt_id_paciente.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_id_paciente.Name = "Txt_id_paciente";
            this.Txt_id_paciente.Size = new System.Drawing.Size(85, 26);
            this.Txt_id_paciente.TabIndex = 8;
            this.Txt_id_paciente.TextChanged += new System.EventHandler(this.Txt_id_paciente_TextChanged);
            // 
            // Mtb_cpf
            // 
            this.Mtb_cpf.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mtb_cpf.Location = new System.Drawing.Point(920, 88);
            this.Mtb_cpf.Margin = new System.Windows.Forms.Padding(4);
            this.Mtb_cpf.Mask = "000.000.000 - 00";
            this.Mtb_cpf.Name = "Mtb_cpf";
            this.Mtb_cpf.Size = new System.Drawing.Size(266, 28);
            this.Mtb_cpf.TabIndex = 7;
            this.Mtb_cpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Mtb_cpf_MaskInputRejected);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(860, 88);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "CPF:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(564, 157);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "E-mail: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(121, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Celular: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data de Nascimento: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(487, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome Completo: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(1206, 47);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Campo obrigatório*";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Btn_cadastrar
            // 
            this.Btn_cadastrar.BackColor = System.Drawing.Color.LightGray;
            this.Btn_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn_cadastrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_cadastrar.ForeColor = System.Drawing.Color.Black;
            this.Btn_cadastrar.Location = new System.Drawing.Point(32, 255);
            this.Btn_cadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_cadastrar.Name = "Btn_cadastrar";
            this.Btn_cadastrar.Size = new System.Drawing.Size(147, 43);
            this.Btn_cadastrar.TabIndex = 3;
            this.Btn_cadastrar.Text = "Cadastrar";
            this.Btn_cadastrar.UseVisualStyleBackColor = false;
            this.Btn_cadastrar.Click += new System.EventHandler(this.Btn_cadastrar_Click);
            // 
            // Btn_alterar
            // 
            this.Btn_alterar.BackColor = System.Drawing.Color.LightGray;
            this.Btn_alterar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn_alterar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_alterar.ForeColor = System.Drawing.Color.Black;
            this.Btn_alterar.Location = new System.Drawing.Point(221, 255);
            this.Btn_alterar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_alterar.Name = "Btn_alterar";
            this.Btn_alterar.Size = new System.Drawing.Size(147, 43);
            this.Btn_alterar.TabIndex = 4;
            this.Btn_alterar.Text = "Alterar";
            this.Btn_alterar.UseVisualStyleBackColor = false;
            this.Btn_alterar.Click += new System.EventHandler(this.Btn_alterar_Click);
            // 
            // Btn_limpar
            // 
            this.Btn_limpar.BackColor = System.Drawing.Color.LightGray;
            this.Btn_limpar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn_limpar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_limpar.ForeColor = System.Drawing.Color.Black;
            this.Btn_limpar.Location = new System.Drawing.Point(411, 255);
            this.Btn_limpar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_limpar.Name = "Btn_limpar";
            this.Btn_limpar.Size = new System.Drawing.Size(147, 43);
            this.Btn_limpar.TabIndex = 5;
            this.Btn_limpar.Text = "Limpar";
            this.Btn_limpar.UseVisualStyleBackColor = false;
            this.Btn_limpar.Click += new System.EventHandler(this.Btn_limpar_Click_1);
            // 
            // Btn_excluir
            // 
            this.Btn_excluir.BackColor = System.Drawing.Color.LightGray;
            this.Btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn_excluir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_excluir.ForeColor = System.Drawing.Color.Black;
            this.Btn_excluir.Location = new System.Drawing.Point(597, 255);
            this.Btn_excluir.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_excluir.Name = "Btn_excluir";
            this.Btn_excluir.Size = new System.Drawing.Size(147, 43);
            this.Btn_excluir.TabIndex = 6;
            this.Btn_excluir.Text = "Excluir";
            this.Btn_excluir.UseVisualStyleBackColor = false;
            this.Btn_excluir.Click += new System.EventHandler(this.Btn_excluir_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Btn_ok);
            this.groupBox3.Controls.Add(this.Txt_filtro);
            this.groupBox3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(16, 319);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(956, 75);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PESQUISA POR NOME";
            // 
            // Btn_ok
            // 
            this.Btn_ok.BackColor = System.Drawing.Color.LightGray;
            this.Btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Btn_ok.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ok.ForeColor = System.Drawing.Color.Black;
            this.Btn_ok.Location = new System.Drawing.Point(852, 14);
            this.Btn_ok.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_ok.Name = "Btn_ok";
            this.Btn_ok.Size = new System.Drawing.Size(79, 48);
            this.Btn_ok.TabIndex = 7;
            this.Btn_ok.Text = "OK";
            this.Btn_ok.UseVisualStyleBackColor = false;
            this.Btn_ok.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Btn_ok_MouseClick);
            // 
            // Txt_filtro
            // 
            this.Txt_filtro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_filtro.Location = new System.Drawing.Point(29, 27);
            this.Txt_filtro.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_filtro.Name = "Txt_filtro";
            this.Txt_filtro.Size = new System.Drawing.Size(800, 35);
            this.Txt_filtro.TabIndex = 0;
            // 
            // Dtv_paciente
            // 
            this.Dtv_paciente.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.Dtv_paciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtv_paciente.Location = new System.Drawing.Point(16, 442);
            this.Dtv_paciente.Margin = new System.Windows.Forms.Padding(4);
            this.Dtv_paciente.Name = "Dtv_paciente";
            this.Dtv_paciente.RowHeadersWidth = 51;
            this.Dtv_paciente.Size = new System.Drawing.Size(1389, 358);
            this.Dtv_paciente.TabIndex = 8;
            this.Dtv_paciente.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Dtv_paciente_MouseDoubleClick_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Info;
            this.label9.Location = new System.Drawing.Point(16, 422);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(435, 21);
            this.label9.TabIndex = 9;
            this.label9.Text = "Selecione com duplo click o paciente desejado";
            // 
            // Frm_paciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1484, 844);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Dtv_paciente);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Btn_excluir);
            this.Controls.Add(this.Btn_limpar);
            this.Controls.Add(this.Btn_alterar);
            this.Controls.Add(this.Btn_cadastrar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Txt);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_paciente";
            this.Text = "Frm_paciente";
            this.Load += new System.EventHandler(this.Frm_paciente_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dtv_paciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Txt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox Mtb_celular;
        private System.Windows.Forms.TextBox Txt_nome;
        private System.Windows.Forms.TextBox Txt_id_paciente;
        private System.Windows.Forms.MaskedTextBox Mtb_cpf;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Rbt_masculino;
        private System.Windows.Forms.RadioButton Rbt_feminino;
        private System.Windows.Forms.TextBox Txt_email;
        private System.Windows.Forms.MaskedTextBox Mtb_data;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Btn_cadastrar;
        private System.Windows.Forms.Button Btn_alterar;
        private System.Windows.Forms.Button Btn_limpar;
        private System.Windows.Forms.Button Btn_excluir;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox Txt_filtro;
        private System.Windows.Forms.Button Btn_ok;
        private System.Windows.Forms.DataGridView Dtv_paciente;
        private System.Windows.Forms.Label label9;
    }
}