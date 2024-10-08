﻿using System;
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
                btnCCadastrar.Enabled = true;
            }
            else
            {
                btnCCadastrar.Enabled = false;
            }
        }


        public frmCadastro()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

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
    }
}
