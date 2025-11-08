namespace Aplicacao_CRUD
{
    partial class Frm_relatorios
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
            this.text_relatorios = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // text_relatorios
            // 
            this.text_relatorios.AutoSize = true;
            this.text_relatorios.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_relatorios.Location = new System.Drawing.Point(310, 181);
            this.text_relatorios.Name = "text_relatorios";
            this.text_relatorios.Size = new System.Drawing.Size(168, 22);
            this.text_relatorios.TabIndex = 0;
            this.text_relatorios.Text = "Em Construção...";
            this.text_relatorios.Click += new System.EventHandler(this.label1_Click);
            // 
            // Frm_relatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.text_relatorios);
            this.Name = "Frm_relatorios";
            this.Text = "Frm_relatorios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label text_relatorios;
    }
}