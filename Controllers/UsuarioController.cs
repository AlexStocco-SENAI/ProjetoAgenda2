using MySql.Data.MySqlClient;
using ProjetoAgenda.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda.Controllers
{
    public class UsuarioController
    {
        public bool AdicionaUsuario(string nome,string login, string senha)
        {
            MySqlConnection conexao = Conexao.criaConexao();

            string comandoInsert = "Insert into usuario (nome, login, senha) VALUES (@nome, @login, @senha);";

            try
            {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand(comandoInsert, conexao);

                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@login", login);
                comando.Parameters.AddWithValue("@senha", senha);

                int resultado = comando.ExecuteNonQuery();

                conexao.Close();

                if (resultado == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CADASTRAR USUARIO: " + ex.Message);
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }

        public List<string> getUsuarios()
        {
            MySqlConnection conexao = Conexao.criaConexao();
            string sql = "Select nome from usuario;";

            MySqlCommand comando = new MySqlCommand(sql, conexao);

            conexao.Open();

            MySqlDataReader resultado = comando.ExecuteReader();
            List<string> nomes = new List<string>();

            while (resultado.Read()){

                nomes.Add(resultado["nome"] as string ?? "-");
            }
            conexao.Close() ;

            return nomes;
            
        }
    }
}
