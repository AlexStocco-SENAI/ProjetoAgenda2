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
            CategoriaController controleCategoria = new CategoriaController();

            bool resultado = controleCategoria.AddCategoria(txtCategoria.Text);

            if (resultado == true)
            {
                MessageBox.Show("Cadastro efetuado com sucesso!");
            }
            else
            {
                MessageBox.Show("Não foi possivel realizar o cadastro");
            }

        }
    }
}
