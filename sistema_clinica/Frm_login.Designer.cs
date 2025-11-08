namespace Aplicacao_CRUD
{
    partial class Frm_login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_usuario = new System.Windows.Forms.Label();
            this.txt_senha = new System.Windows.Forms.Label();
            this.text_usuario = new System.Windows.Forms.TextBox();
            this.text_senha = new System.Windows.Forms.TextBox();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_usuario
            // 
            this.txt_usuario.AutoSize = true;
            this.txt_usuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.ForeColor = System.Drawing.Color.Black;
            this.txt_usuario.Location = new System.Drawing.Point(65, 86);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(70, 18);
            this.txt_usuario.TabIndex = 0;
            this.txt_usuario.Text = "Usuário";
            // 
            // txt_senha
            // 
            this.txt_senha.AutoSize = true;
            this.txt_senha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_senha.Location = new System.Drawing.Point(76, 132);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(59, 18);
            this.txt_senha.TabIndex = 1;
            this.txt_senha.Text = "Senha";
            this.txt_senha.Click += new System.EventHandler(this.label2_Click);
            // 
            // text_usuario
            // 
            this.text_usuario.Location = new System.Drawing.Point(160, 84);
            this.text_usuario.Name = "text_usuario";
            this.text_usuario.Size = new System.Drawing.Size(150, 20);
            this.text_usuario.TabIndex = 2;
            this.text_usuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // text_senha
            // 
            this.text_senha.Location = new System.Drawing.Point(160, 130);
            this.text_senha.Name = "text_senha";
            this.text_senha.Size = new System.Drawing.Size(150, 20);
            this.text_senha.TabIndex = 3;
            // 
            // btn_entrar
            // 
            this.btn_entrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entrar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_entrar.Location = new System.Drawing.Point(127, 210);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(165, 43);
            this.btn_entrar.TabIndex = 4;
            this.btn_entrar.Text = "Entrar";
            this.btn_entrar.UseVisualStyleBackColor = true;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // Frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(418, 340);
            this.Controls.Add(this.btn_entrar);
            this.Controls.Add(this.text_senha);
            this.Controls.Add(this.text_usuario);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.txt_usuario);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento de clínica";
            this.Load += new System.EventHandler(this.Frm_login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_usuario;
        private System.Windows.Forms.Label txt_senha;
        private System.Windows.Forms.TextBox text_usuario;
        private System.Windows.Forms.TextBox text_senha;
        private System.Windows.Forms.Button btn_entrar;
    }
}

