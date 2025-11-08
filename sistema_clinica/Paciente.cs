using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacao_CRUD
{
    internal partial class Paciente
    {
        //ATRIBUTOS
        public int id_paciente { get; set; }
        public string nome { get; set; }
        public string dt_nasc { get; set; }
        public string sexo { get; set; }
        public string cpf { get; set; }
        public string celular { get; set; }
        public string email { get; set; }

        public ConexaoBanco banco;


        //CONSTRUTOR
        public Paciente()
        {
            this.id_paciente = 0;
            this.nome = "";
            this.dt_nasc = "";
            this.sexo = "";
            this.cpf = "";
            this.celular = "";
            this.email = "";

            this.banco = new ConexaoBanco();
        }


        // CRIAR METODO PARA BUSCAR PACIENTES PARA O GRID
        public MySqlDataReader listarPaciente()
        {
            this.banco.conectar();
            return this.banco.Query("select p.id_paciente, p.nome, p.dt_nasc, p.sexo, p.CPF, p.celular, p.email from paciente p;");
        }



        // CRIAR METODO PARA BUSCAR PACIENTES PELO BOTÃO OK
        public MySqlDataReader listarPacientePorOk(string filtro)
        {
            this.banco.conectar();
            return this.banco.Query("select p.id_paciente, p.nome, p.dt_nasc, p.sexo, p.cpf, p.celular, p.email from paciente p where p.nome like '%" + filtro + "%'; ");
        }



        // ---INSERIR---
        public void cadastrarPaciente()
        {
            this.banco.conectar();
            this.banco.nonQuery("INSERT INTO paciente (`nome`, `dt_nasc`,`sexo`," +
                "`cpf`, `celular`,`email`) VALUES ('" +
                this.nome + "', '" +
                this.dt_nasc + "', '" +
                this.sexo + "', '" +
                this.cpf + "', '" +
                this.celular + "', '" +
                this.email + "');");
            this.banco.close();
        }



        // ---ALTERAR---
        public void alterarPaciente()
        {
            this.banco.conectar();
            this.banco.nonQuery("UPDATE paciente set nome='" + this.nome +
                "', dt_nasc='" + this.dt_nasc +
                "', sexo='" + this.sexo +
                "', cpf='" + this.cpf +
                "', celular='" + this.celular +
                "', email='" + this.email +
                "' where id_paciente ='" + this.id_paciente + "';");
            this.banco.close();
        }




        // ---EXCLUIR---
        public void excluirPaciente()
        {
            this.banco.conectar();
            this.banco.nonQuery("Delete from paciente where id_paciente ='" + this.id_paciente + "'");
            this.banco.close();
        }


    }
}
