using ProjetoAgenda.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAgenda.Views
{
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string categoria = txtCategoria.Text;
            CategoriaController controleCategoria = new CategoriaController();
            bool resultado = controleCategoria.AddCategoria(categoria);

            if (resultado)
            {
                MessageBox.Show("Categoria cadastrada com sucesso!");
            }

            else
            {
                MessageBox.Show("Não foi possivel cadastrar.");
            }
        }

        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CategoriaController controleCategoria = new CategoriaController();
            DataTable tabela = controleCategoria.GetCategorias();
            dgvCategoria.DataSource = tabela;
        }
    }
}
