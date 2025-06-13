namespace TrabalhoBiblioteca
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btncadastrolivro = new Button();
            btnCadastrouser = new Button();
            btnAlocarlivro = new Button();
            btnfechar = new Button();
            SuspendLayout();
            // 
            // btncadastrolivro
            // 
            btncadastrolivro.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncadastrolivro.Location = new Point(266, 35);
            btncadastrolivro.Name = "btncadastrolivro";
            btncadastrolivro.Size = new Size(279, 64);
            btncadastrolivro.TabIndex = 0;
            btncadastrolivro.Text = "Cadastrar Livro";
            btncadastrolivro.UseVisualStyleBackColor = true;
            btncadastrolivro.Click += btncadastrolivro_Click;
            // 
            // btnCadastrouser
            // 
            btnCadastrouser.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrouser.Location = new Point(266, 125);
            btnCadastrouser.Name = "btnCadastrouser";
            btnCadastrouser.Size = new Size(279, 64);
            btnCadastrouser.TabIndex = 1;
            btnCadastrouser.Text = "Cadastrar Usuario";
            btnCadastrouser.UseVisualStyleBackColor = true;
            btnCadastrouser.Click += btnCadastrouser_Click;
            // 
            // btnAlocarlivro
            // 
            btnAlocarlivro.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAlocarlivro.Location = new Point(266, 219);
            btnAlocarlivro.Name = "btnAlocarlivro";
            btnAlocarlivro.Size = new Size(279, 64);
            btnAlocarlivro.TabIndex = 2;
            btnAlocarlivro.Text = "Alocar Livro";
            btnAlocarlivro.UseVisualStyleBackColor = true;
            // 
            // btnfechar
            // 
            btnfechar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnfechar.Location = new Point(320, 317);
            btnfechar.Name = "btnfechar";
            btnfechar.Size = new Size(175, 55);
            btnfechar.TabIndex = 3;
            btnfechar.Text = "Fechar";
            btnfechar.UseVisualStyleBackColor = true;
            btnfechar.Click += btnfechar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 419);
            Controls.Add(btnfechar);
            Controls.Add(btnAlocarlivro);
            Controls.Add(btnCadastrouser);
            Controls.Add(btncadastrolivro);
            Name = "Form1";
            Text = "Biblioteca";
            ResumeLayout(false);
        }

        #endregion

        private Button btncadastrolivro;
        private Button btnCadastrouser;
        private Button btnAlocarlivro;
        private Button btnfechar;
    }
}
