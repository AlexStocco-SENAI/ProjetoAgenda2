namespace ProjetoAgenda.Views
{
    partial class frmCategoria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txtCategoria = new TextBox();
            btnCadastrar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCadastrar);
            groupBox1.Controls.Add(txtCategoria);
            groupBox1.Location = new Point(19, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(209, 117);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Insira o nome da nova categoria";
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(17, 29);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(177, 23);
            txtCategoria.TabIndex = 0;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(18, 63);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(177, 34);
            btnCadastrar.TabIndex = 1;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // frmCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(248, 149);
            Controls.Add(groupBox1);
            Name = "frmCategoria";
            Text = "frmCategoria";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCadastrar;
        private TextBox txtCategoria;
    }
}