using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao_CRUD
{
    internal partial class Usuarios
    {
        public string usuario { get; set; }
        public string senha { get; set; }

        public ConexaoBanco banco = new ConexaoBanco();

        //METODO QUE VERIFICA NO BANCO DE DADOS SE O USUARIO EXISTE
        public string verificarLogin()
        {
            this.banco.conectar();
            try
            {
                MySqlDataReader reader = this.banco.Query("SELECT * FROM usuarios WHERE usuario='" + this.usuario + "' AND senha='" + this.senha + "'");

                if (reader.Read())
                {
                    return "aceito";
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("ERRO ao fazer a verificação na base da dados");
            }
            this.banco.close();
            return "negado";
        }

    }
}
