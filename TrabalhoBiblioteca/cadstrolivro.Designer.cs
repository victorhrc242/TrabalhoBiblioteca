namespace TrabalhoBiblioteca
{
    partial class cadstrolivro
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
            txttitulo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtAutor = new TextBox();
            btnGravar = new Button();
            btnlimpar = new Button();
            btnFechar = new Button();
            SuspendLayout();
            // 
            // txttitulo
            // 
            txttitulo.Location = new Point(248, 69);
            txttitulo.Name = "txttitulo";
            txttitulo.Size = new Size(308, 23);
            txttitulo.TabIndex = 0;
            txttitulo.TextChanged += txttitulo_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(176, 69);
            label1.Name = "label1";
            label1.Size = new Size(66, 23);
            label1.TabIndex = 1;
            label1.Text = "Titulo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(325, 22);
            label2.Name = "label2";
            label2.Size = new Size(160, 24);
            label2.TabIndex = 2;
            label2.Text = "Cadastro Livro";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(176, 122);
            label3.Name = "label3";
            label3.Size = new Size(64, 23);
            label3.TabIndex = 3;
            label3.Text = "Autor:";
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(248, 125);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(308, 23);
            txtAutor.TabIndex = 4;
            txtAutor.TextChanged += txtAutor_TextChanged;
            // 
            // btnGravar
            // 
            btnGravar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGravar.Location = new Point(97, 242);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(175, 55);
            btnGravar.TabIndex = 5;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnlimpar
            // 
            btnlimpar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlimpar.Location = new Point(310, 242);
            btnlimpar.Name = "btnlimpar";
            btnlimpar.Size = new Size(175, 55);
            btnlimpar.TabIndex = 6;
            btnlimpar.Text = "Limpar";
            btnlimpar.UseVisualStyleBackColor = true;
            btnlimpar.Click += button1_Click;
            // 
            // btnFechar
            // 
            btnFechar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFechar.Location = new Point(541, 242);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(175, 55);
            btnFechar.TabIndex = 7;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // cadstrolivro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFechar);
            Controls.Add(btnlimpar);
            Controls.Add(btnGravar);
            Controls.Add(txtAutor);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txttitulo);
            Name = "cadstrolivro";
            Text = "cadstrolivro";
            Load += cadstrolivro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txttitulo;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtAutor;
        private Button btnGravar;
        private Button btnlimpar;
        private Button btnFechar;
    }
}