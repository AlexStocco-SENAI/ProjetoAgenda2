using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda.Data
{
    static public class Conexao
    {
        static public MySqlConnection criaConexao()
        {
            string stringConexao = "Server=localhost;Database=dbAgenda;User ID=root;Password=root;";
            MySqlConnection conexao = new MySqlConnection(stringConexao);

            return conexao;
        }
    }
}
