using ProjetoAgenda.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAgenda.View
{
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(new CategoriaController().AdicionaCategoria(textBox1.Text)));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = new CategoriaController().getAdapterCategorias();
            comboBox1.DataSource = new CategoriaController().getAdapterCategorias();
            comboBox1.DisplayMember = "categoria";
            comboBox1.ValueMember = "codcategoria";
            dataGridView2.Columns[0].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string codcategoriaSelecionada = comboBox1.SelectedValue.ToString();
            MessageBox.Show("Código da categoria selecionada: " + codcategoriaSelecionada);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int codcategoria = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["codcategoria"].Value);
            bool resultado = new CategoriaController().ExcluiraCategoria(codcategoria);
            MessageBox.Show(resultado.ToString());
        }
    }
}
