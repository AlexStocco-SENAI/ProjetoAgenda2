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
}
