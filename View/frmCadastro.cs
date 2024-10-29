using MySql.Data.MySqlClient;
using ProjetoAgenda.Controllers;
using ProjetoAgenda.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAgenda
{
    public partial class frmCadastro : Form
    {
        private void habilitarBotaoCadastrar()
        {
            bool erro = false;

            //verifica o nome
            if (txtNome.Text == "")
            {
                erro = true;
            }

            //verifica usuario
            if (txtUsuario.Text == "")
            {
                erro = true;
            }

            //verificar senha
            if (txtSenha.Text.Length < 8)
            {
                erro = true;
            }

            //verifica se as senha são diferentes
            if (txtSenha.Text != txtRepeteSenha.Text)
            {
                erro = true;
            }

            //Caso não encontre nenhum erro habilita o botão cadastrar
            if (erro == false)
            {
                btnCadastrar.Enabled = true;
            }
            else
            {
                btnCadastrar.Enabled = false;
            }
        }


        public frmCadastro()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            MySqlConnection conexao = Conexao.criaConexao();


        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            habilitarBotaoCadastrar();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            habilitarBotaoCadastrar();
        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            habilitarBotaoCadastrar();
        }

        private void txtRepeteSenha_TextChanged(object sender, EventArgs e)
        {
            habilitarBotaoCadastrar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string login = txtTelefone.Text;
            string senha = txtSenha.Text;

            UsuarioController usuarioController = new UsuarioController();

            bool resultado = usuarioController.AdicionaUsuario(nome, login, senha);

            if (resultado)
            {
                MessageBox.Show("Cadastro efetuado com sucesso!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioController usuarioController = new UsuarioController();

            List<string> nome = usuarioController.getUsuarios();
            
            Dictionary<string,string> dict = new Dictionary<string, string>(); 
            List<List<string>> list = new List<List<string>>();

            dataGridView1.Columns.Add("Nome1", "Nome2");
            dataGridView1.Columns.Add("Nome3", "Nome4");

            // Usa foreach para adicionar cada nome como uma nova linha
            foreach (var s in nome)
            {
                dataGridView1.Rows.Add(s, s); // Adiciona uma nova linha com o nome
            }


        }
    }
}
