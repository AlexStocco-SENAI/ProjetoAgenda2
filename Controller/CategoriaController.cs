using MySql.Data.MySqlClient;
using ProjetoAgenda.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda.Controller
{
    internal class CategoriaController
    {
        public bool AddCategoria(string categoria)
        {
            MySqlConnection conexao = null;
            try
            {
                conexao = ConexaoDB.CriarConexao();

                string sql = @"INSERT INTO tbcategoria
	                        (categoria)
	                        VALUES
	                        (@categoria);";

                conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, conexao);

                comando.Parameters.AddWithValue("@categoria", categoria);

                int linhasAfetadas = comando.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                { return true; }
                else
                { return false; }

                
            }
            catch (Exception erro)
            {
                MessageBox.Show($"ERRO AO CADASTRAR CATEGORIA: {erro.Message}");
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }

        public DataTable GetCategorias()
        {
            MySqlConnection conexao = null;

            try
            {
                conexao = ConexaoDB.CriarConexao();

                string sql = @"SELECT codCategoria AS 'Código', categoria AS 'Categoria'
                                FROM tbcategoria;";

                conexao.Open();


            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao recuperar categorias: {erro.Message}");
            }


        }
    }
}
