using MySql.Data.MySqlClient;
using ProjetoAgenda.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda.Controllers
{
    public class CategoriaController
    {
        public bool AdicionaCategoria(string categoria)
        {
            MySqlConnection conexao = Conexao.criaConexao();

            string comandoInsert = "Insert into tbcategoria (categoria) VALUES (@categoria);";

            try
            {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand(comandoInsert, conexao);

                comando.Parameters.AddWithValue("@categoria", categoria);

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

        public List<string> getCategorias()
        {
            MySqlConnection conexao = Conexao.criaConexao();
            string sql = "Select codcategoria, categoria from usuario;";

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

        public DataTable getAdapterCategorias()
        {
            MySqlConnection conexao = Conexao.criaConexao();
            string sql = "Select * from tbcategoria;";

            // Criar o adaptador
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conexao);

            // Criar um DataTable para armazenar os resultados
            DataTable dataTable = new DataTable();

            // Abrir a conexão
            conexao.Open();

            // Preencher o DataTable com os dados do banco de dados
            adapter.Fill(dataTable);

            conexao.Close();


            return dataTable;
        }

        public bool ExcluiraCategoria(int codcategoria)
        {
            MySqlConnection conexao = Conexao.criaConexao();

            string comandoInsert = "delete from tbcategoria where codcategoria= @codcategoria;";

            try
            {
                conexao.Open();

                MySqlCommand comando = new MySqlCommand(comandoInsert, conexao);

                comando.Parameters.AddWithValue("@codcategoria", codcategoria);

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
                MessageBox.Show("ERRO AO EXCLUIR CATEGORIA: " + ex.Message);
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }
    }

    private Dictionary<int, string> ObterDados()
    {
        string connectionString = "Server=localhost;Database=LojaDB;Uid=root;Pwd=minhaSenha;Port=3306;";
        Dictionary<int, string> resultados = new Dictionary<int, string>();

        using (MySqlConnection conn = new MySqlConnection(connectionString))
        {
            try
            {
                string sql = "SELECT Id, Nome FROM Clientes";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32("Id");
                        string nome = reader.GetString("Nome");
                        resultados.Add(id, nome);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter dados: " + ex.Message);
            }
        }
        return resultados;
    }
}
