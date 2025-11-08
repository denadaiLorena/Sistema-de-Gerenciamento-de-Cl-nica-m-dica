namespace Aplicacao_CRUD
{
    partial class Frm_menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_menu));
            this.Pnl_top = new System.Windows.Forms.Panel();
            this.Btn_restaurar = new System.Windows.Forms.Button();
            this.Btn_maximizar = new System.Windows.Forms.Button();
            this.Btn_fechar = new System.Windows.Forms.Button();
            this.Pnl_menu = new System.Windows.Forms.Panel();
            this.Btn_sair = new System.Windows.Forms.Button();
            this.Btn_relatorios = new System.Windows.Forms.Button();
            this.Btn_pacientes = new System.Windows.Forms.Button();
            this.Pnl_cont = new System.Windows.Forms.Panel();
            this.Pnl_top.SuspendLayout();
            this.Pnl_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_top
            // 
            this.Pnl_top.BackColor = System.Drawing.Color.SteelBlue;
            this.Pnl_top.Controls.Add(this.Btn_restaurar);
            this.Pnl_top.Controls.Add(this.Btn_maximizar);
            this.Pnl_top.Controls.Add(this.Btn_fechar);
            this.Pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_top.Location = new System.Drawing.Point(0, 0);
            this.Pnl_top.Margin = new System.Windows.Forms.Padding(4);
            this.Pnl_top.Name = "Pnl_top";
            this.Pnl_top.Size = new System.Drawing.Size(1445, 60);
            this.Pnl_top.TabIndex = 0;
            // 
            // Btn_restaurar
            // 
            this.Btn_restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_restaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_restaurar.ForeColor = System.Drawing.Color.SteelBlue;
            this.Btn_restaurar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_restaurar.Image")));
            this.Btn_restaurar.Location = new System.Drawing.Point(1263, 2);
            this.Btn_restaurar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_restaurar.Name = "Btn_restaurar";
            this.Btn_restaurar.Size = new System.Drawing.Size(53, 32);
            this.Btn_restaurar.TabIndex = 2;
            this.Btn_restaurar.UseVisualStyleBackColor = true;
            this.Btn_restaurar.Click += new System.EventHandler(this.btn_restaurar_Click);
            // 
            // Btn_maximizar
            // 
            this.Btn_maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_maximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_maximizar.ForeColor = System.Drawing.Color.SteelBlue;
            this.Btn_maximizar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_maximizar.Image")));
            this.Btn_maximizar.Location = new System.Drawing.Point(1325, 5);
            this.Btn_maximizar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_maximizar.Name = "Btn_maximizar";
            this.Btn_maximizar.Size = new System.Drawing.Size(53, 28);
            this.Btn_maximizar.TabIndex = 1;
            this.Btn_maximizar.UseVisualStyleBackColor = true;
            // 
            // Btn_fechar
            // 
            this.Btn_fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_fechar.BackColor = System.Drawing.Color.SteelBlue;
            this.Btn_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_fechar.ForeColor = System.Drawing.Color.SteelBlue;
            this.Btn_fechar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_fechar.Image")));
            this.Btn_fechar.Location = new System.Drawing.Point(1390, 5);
            this.Btn_fechar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_fechar.Name = "Btn_fechar";
            this.Btn_fechar.Size = new System.Drawing.Size(39, 32);
            this.Btn_fechar.TabIndex = 0;
            this.Btn_fechar.UseVisualStyleBackColor = false;
            this.Btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // Pnl_menu
            // 
            this.Pnl_menu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Pnl_menu.Controls.Add(this.Btn_sair);
            this.Pnl_menu.Controls.Add(this.Btn_relatorios);
            this.Pnl_menu.Controls.Add(this.Btn_pacientes);
            this.Pnl_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Pnl_menu.Location = new System.Drawing.Point(0, 60);
            this.Pnl_menu.Margin = new System.Windows.Forms.Padding(4);
            this.Pnl_menu.Name = "Pnl_menu";
            this.Pnl_menu.Size = new System.Drawing.Size(260, 693);
            this.Pnl_menu.TabIndex = 1;
            this.Pnl_menu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_menu);
            // 
            // Btn_sair
            // 
            this.Btn_sair.BackColor = System.Drawing.Color.SteelBlue;
            this.Btn_sair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.Btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_sair.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_sair.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_sair.Image = ((System.Drawing.Image)(resources.GetObject("Btn_sair.Image")));
            this.Btn_sair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_sair.Location = new System.Drawing.Point(4, 188);
            this.Btn_sair.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_sair.Name = "Btn_sair";
            this.Btn_sair.Size = new System.Drawing.Size(204, 85);
            this.Btn_sair.TabIndex = 4;
            this.Btn_sair.Text = "Sair";
            this.Btn_sair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_sair.UseVisualStyleBackColor = false;
            this.Btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // Btn_relatorios
            // 
            this.Btn_relatorios.BackColor = System.Drawing.Color.SteelBlue;
            this.Btn_relatorios.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_relatorios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_relatorios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.Btn_relatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_relatorios.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_relatorios.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_relatorios.Image = ((System.Drawing.Image)(resources.GetObject("Btn_relatorios.Image")));
            this.Btn_relatorios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_relatorios.Location = new System.Drawing.Point(4, 96);
            this.Btn_relatorios.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_relatorios.Name = "Btn_relatorios";
            this.Btn_relatorios.Size = new System.Drawing.Size(204, 85);
            this.Btn_relatorios.TabIndex = 3;
            this.Btn_relatorios.Text = "Relatórios";
            this.Btn_relatorios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_relatorios.UseVisualStyleBackColor = false;
            this.Btn_relatorios.Click += new System.EventHandler(this.Btn_relatorios_Click);
            // 
            // Btn_pacientes
            // 
            this.Btn_pacientes.BackColor = System.Drawing.Color.SteelBlue;
            this.Btn_pacientes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_pacientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Btn_pacientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.Btn_pacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_pacientes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_pacientes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_pacientes.Image = ((System.Drawing.Image)(resources.GetObject("Btn_pacientes.Image")));
            this.Btn_pacientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_pacientes.Location = new System.Drawing.Point(4, 9);
            this.Btn_pacientes.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_pacientes.Name = "Btn_pacientes";
            this.Btn_pacientes.Size = new System.Drawing.Size(204, 80);
            this.Btn_pacientes.TabIndex = 1;
            this.Btn_pacientes.Text = "Pacientes";
            this.Btn_pacientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_pacientes.UseVisualStyleBackColor = false;
            this.Btn_pacientes.Click += new System.EventHandler(this.Btn_pacientes_Click);
            // 
            // Pnl_cont
            // 
            this.Pnl_cont.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Pnl_cont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_cont.Location = new System.Drawing.Point(260, 60);
            this.Pnl_cont.Margin = new System.Windows.Forms.Padding(4);
            this.Pnl_cont.Name = "Pnl_cont";
            this.Pnl_cont.Size = new System.Drawing.Size(1185, 693);
            this.Pnl_cont.TabIndex = 2;
            this.Pnl_cont.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnl_cont_Paint);
            // 
            // Frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1445, 753);
            this.Controls.Add(this.Pnl_cont);
            this.Controls.Add(this.Pnl_menu);
            this.Controls.Add(this.Pnl_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_menu_Load);
            this.Pnl_top.ResumeLayout(false);
            this.Pnl_menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_top;
        private System.Windows.Forms.Button Btn_fechar;
        private System.Windows.Forms.Button Btn_maximizar;
        private System.Windows.Forms.Button Btn_restaurar;
        private System.Windows.Forms.Panel Pnl_menu;
        private System.Windows.Forms.Button Btn_pacientes;
        private System.Windows.Forms.Button Btn_sair;
        private System.Windows.Forms.Button Btn_relatorios;
        private System.Windows.Forms.Panel Pnl_cont;
       
    }
}