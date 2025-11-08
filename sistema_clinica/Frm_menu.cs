using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacao_CRUD
{
    public partial class Frm_menu : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        public Frm_menu()
        {
            InitializeComponent();
        }

        //método genérico para abrir formulários no panel de conteúdo
        private void AbrirFormNoPanel<Forms>() where Forms : Form, new()
        {
            Form formulario;
            formulario = Pnl_cont.Controls.OfType<Forms>().FirstOrDefault();
            {
                if (formulario == null)
                {
                    formulario = new Forms();
                    formulario.TopLevel = false;
                    formulario.FormBorderStyle = FormBorderStyle.None;
                    formulario.Dock = DockStyle.Fill;
                    Pnl_cont.Controls.Add(formulario);
                    Pnl_cont.Tag = formulario;
                    formulario.Show();
                    formulario.BringToFront();
                }
                else
                {
                    if (formulario.WindowState == FormWindowState.Minimized)
                    {
                        formulario.WindowState = FormWindowState.Normal;
                    }
                    formulario.BringToFront();
                }
            }
        }


        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btn_maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Btn_restaurar.Visible = true;
        }
        private void btn_restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            Btn_restaurar.Visible = false;
            Btn_maximizar.Visible = true;
        }
        private void pnl_top_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
       
        private void pnl_menu(object sender, EventArgs e)
        {
        }
        private void Frm_menu_Load(object sender, EventArgs e)
        {

        }



        //métodos para chamada dos formulários
        private void Btn_pacientes_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Frm_paciente>();
        }
        private void Btn_relatorios_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Frm_relatorios>();
        }

        private void Pnl_cont_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
