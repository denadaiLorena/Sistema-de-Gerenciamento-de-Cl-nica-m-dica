using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacao_CRUD
{
    public partial class Frm_paciente : Form
    {

        //ATRIBUTOS
        private Paciente paciente = new Paciente();
        private ConexaoBanco banco = new ConexaoBanco();

        string sexo = "";


        //CONSTRUTOR DO FORMULARIO
        public Frm_paciente()
        {
            InitializeComponent();
            atualizarDataGrid();
            limparCampos();
        }


        //METODO PARA ATUALIZAR OS DADOS JÁ CADASTRADOS
        private void atualizarDataGrid()
        {
            MySqlDataReader temp = paciente.listarPaciente();
            DataTable dt = new DataTable();
            dt.Load(temp);
            Dtv_paciente.DataSource = dt;
        }


        //LIMPAR CAMPOS
        private void limparCampos()
        {
            Txt_id_paciente.Clear();
            Txt_nome.Text = "";
            Mtb_data.Text = "";
            Rbt_feminino.Checked = false;
            Rbt_masculino.Checked = false;
            Mtb_cpf.Text = "";
            Mtb_celular.Text = "";
            Txt_email.Text = "";
        }


        //INSERE UM NOVO PACIENTE
        private void Btn_cadastrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Txt_nome.Text) && 
                !string.IsNullOrWhiteSpace(Mtb_data.Text.Replace("/", "").Trim()) &&
                !string.IsNullOrWhiteSpace(Mtb_cpf.Text.Replace("_", "").Replace(",", "").Replace("-", "").Trim()))
            {
                this.paciente.nome = Txt_nome.Text;
                this.paciente.dt_nasc = Mtb_data.Text;
                this.paciente.sexo = Rbt_feminino.Checked ? "F" : "M";
                this.paciente.cpf = Mtb_cpf.Text;
                this.paciente.celular = Mtb_celular.Text;
                this.paciente.email = Txt_email.Text;
                this.paciente.cadastrarPaciente();//esta na classe paciente

                MessageBox.Show("Cadastro realizado com sucesso!");
                limparCampos();
            }
            else
            {
                MessageBox.Show("Preencha os campos obrigatórios (Nome, CPF e data de nascimento).");
            }
            atualizarDataGrid();
        }


        private void Rbt_feminino_CheckedChanged(object sender, EventArgs e)
        {
            this.sexo = "F";
        }

        private void Rbt_masculino_CheckedChanged(object sender, EventArgs e)
        {
            this.sexo = "M";
        }


        //PESQUISA UM PACIENTE PELO NOME
        private void Btn_ok_MouseClick(object sender, MouseEventArgs e)
        {
            String filtro = Txt_filtro.Text;
            MySqlDataReader temp = this.paciente.listarPacientePorOk(filtro);
            DataTable dt = new DataTable();
            dt.Load(temp);
            Dtv_paciente.DataSource = dt;
            Txt_filtro.Clear();
        }



        private void label3_Click(object sender, EventArgs e)
        {
        }
        private void Mtb_cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }
        private void label8_Click(object sender, EventArgs e)
        {
        }

        //ALTERAR PACIENTE
        private void Btn_alterar_Click(object sender, EventArgs e)
        {
            this.paciente.id_paciente = int.Parse(Txt_id_paciente.Text);
            this.paciente.nome = Txt_nome.Text;
            this.paciente.dt_nasc = Mtb_data.Text;
            if (Rbt_feminino.Checked == true)
                this.sexo = "F";
            else
                this.sexo = "M";
            this.paciente.cpf = Mtb_cpf.Text;
            this.paciente.celular = Mtb_celular.Text;
            this.paciente.email = Txt_email.Text;
            this.paciente.alterarPaciente();

            MessageBox.Show("Alteração realizada com sucesso!");
            limparCampos();
            atualizarDataGrid();
        }

        private void Txt_id_paciente_TextChanged(object sender, EventArgs e)
        {
        }

        private void Frm_paciente_Load_1(object sender, EventArgs e)
        {
            atualizarDataGrid();
            limparCampos();

        }

        private void Dtv_paciente_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            int linhaAtual = 0;
            linhaAtual = Dtv_paciente.CurrentRow.Index;
            try
            {
                Txt_id_paciente.Text = Dtv_paciente[0, linhaAtual].Value.ToString();
                Txt_nome.Text = Dtv_paciente[1, linhaAtual].Value.ToString();
                Mtb_data.Text = Dtv_paciente[2, linhaAtual].Value.ToString();
                this.sexo = Dtv_paciente[3, linhaAtual].Value.ToString();
                if (this.sexo == "F")
                {
                    Rbt_feminino.Checked = true;
                }
                else
                {
                    if (this.sexo == "M")
                    {
                        Rbt_masculino.Checked = true;
                    }
                    else
                    {
                        Rbt_feminino.Checked = false;
                        Rbt_masculino.Checked = false;
                    }
                }
                Mtb_cpf.Text = Dtv_paciente[4, linhaAtual].Value.ToString();
                Mtb_celular.Text = Dtv_paciente[5, linhaAtual].Value.ToString();
                Txt_email.Text = Dtv_paciente[6, linhaAtual].Value.ToString();
            }
            catch
            {
                MessageBox.Show("ERRO no preenchimento dos dados.");
            }
        }


        //EXCLUIR PACIENTE
        private void Btn_excluir_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja remover Cliente?", "Confirmar", MessageBoxButtons.
              YesNoCancel) == DialogResult.Yes)
            {
                if (Txt_id_paciente.Text != "")
                {
                    this.paciente.id_paciente = int.Parse(Txt_id_paciente.Text);
                    this.paciente.excluirPaciente();
                    atualizarDataGrid();
                    limparCampos();
                }
            }

        }


        //LIMPAR CAMPOS
        private void Btn_limpar_Click_1(object sender, EventArgs e)
        {
            atualizarDataGrid();
            limparCampos();
        }

        private void Rbt_masculino_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
