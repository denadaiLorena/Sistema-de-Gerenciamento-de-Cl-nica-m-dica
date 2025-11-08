using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacao_CRUD
{
    public partial class Frm_login : Form
    {
        //ATRIBUTO
        Usuarios entrada = new Usuarios();

        //CONSTRUTOR
        public Frm_login()
        {
            InitializeComponent();
        }

        private void Frm_login_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            entrada.usuario = text_usuario.Text;
            entrada.senha = text_senha.Text;

            if (entrada.verificarLogin() == "aceito")
            {
                Frm_menu form = new Frm_menu();
                this.Hide();      //esconde o formulario de login
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuário ou Senha Inválidos", "Erro ao entrar no Sistema");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
