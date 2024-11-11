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

                string sql = "INSERT INTO tbcategoria(categoria) VALUES(@categoria);";

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
                MessageBox.Show($"ERRO AO INSERIR CATEGORIA: {erro.Message}");
                return false;
            }
            finally
            {
                conexao.Close();
            }
        }

        public DataTable GetCategorias()
        {
            //Criando uma conexão vazia
            MySqlConnection conexao = null;

            try
            {
                //Inserindo a conexão usando a ConexaoDB que eu já havia criado
                 conexao = ConexaoDB.CriarConexao();

                //Montei o SELECT que retorna todas as categorias
                string sql = @"select cod_categoria AS 'Código', categoria AS 'Categoria'
                            from tbcategoria;";

                //Abri a conexão
                conexao.Open();

                //Crie um adaptador
                MySqlDataAdapter adaptador = new MySqlDataAdapter(sql, conexao);

                //Criei uma tabela vazia
                DataTable tabela = new DataTable();

                //Pedindo para o adaptador preencher a tabela
                adaptador.Fill(tabela);

                //Retorno a tabela preenchida
                return tabela;
            }
            catch (Exception erro)
            {
                MessageBox.Show($"ERRO AO RECUPERAR CATEGORIAS: {erro.Message}");
                return new DataTable();
            }
            finally
            {
                conexao.Close();
            }


        }
    }
}
