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
            btnCadastrar = new Button();
            txtCategoria = new TextBox();
            btnFechar = new Button();
            dgvCategoria = new DataGridView();
            button1 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCadastrar);
            groupBox1.Controls.Add(txtCategoria);
            groupBox1.Location = new Point(32, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(239, 116);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Insira a nova categoria";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(6, 58);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(220, 42);
            btnCadastrar.TabIndex = 1;
            btnCadastrar.Text = "&Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(6, 29);
            txtCategoria.MaxLength = 45;
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(220, 23);
            txtCategoria.TabIndex = 0;
            txtCategoria.TextChanged += txtCategoria_TextChanged;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.FromArgb(192, 0, 0);
            btnFechar.Location = new Point(12, 156);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(62, 33);
            btnFechar.TabIndex = 1;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = false;
            // 
            // dgvCategoria
            // 
            dgvCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategoria.Location = new Point(301, 33);
            dgvCategoria.Name = "dgvCategoria";
            dgvCategoria.Size = new Size(247, 148);
            dgvCategoria.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(365, 4);
            button1.Name = "button1";
            button1.Size = new Size(120, 26);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 194);
            Controls.Add(button1);
            Controls.Add(dgvCategoria);
            Controls.Add(btnFechar);
            Controls.Add(groupBox1);
            Name = "frmCategoria";
            Text = "frmCategoria";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCadastrar;
        private TextBox txtCategoria;
        private Button btnFechar;
        private DataGridView dgvCategoria;
        private Button button1;
    }
}