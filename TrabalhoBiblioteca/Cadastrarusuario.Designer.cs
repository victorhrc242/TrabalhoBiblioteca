namespace TrabalhoBiblioteca
{
    partial class Cadastrarusuario
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
            label2 = new Label();
            txtusuario = new TextBox();
            txtsobrenome = new TextBox();
            textcidade = new TextBox();
            textuf = new TextBox();
            textcep = new TextBox();
            texttelefone = new TextBox();
            textcelular = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            btnGravar = new Button();
            btnlimpar = new Button();
            btnFechar = new Button();
            dtpNascimento = new DateTimePicker();
            label10 = new Label();
            txtcepf = new MaskedTextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(301, 9);
            label2.Name = "label2";
            label2.Size = new Size(184, 24);
            label2.TabIndex = 3;
            label2.Text = "Cadastro usuario";
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(237, 76);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(308, 23);
            txtusuario.TabIndex = 4;
            txtusuario.TextChanged += txtusuario_TextChanged;
            // 
            // txtsobrenome
            // 
            txtsobrenome.Location = new Point(237, 115);
            txtsobrenome.Name = "txtsobrenome";
            txtsobrenome.Size = new Size(308, 23);
            txtsobrenome.TabIndex = 5;
            // 
            // textcidade
            // 
            textcidade.Location = new Point(237, 195);
            textcidade.Name = "textcidade";
            textcidade.Size = new Size(308, 23);
            textcidade.TabIndex = 7;
            // 
            // textuf
            // 
            textuf.Location = new Point(237, 238);
            textuf.Name = "textuf";
            textuf.Size = new Size(308, 23);
            textuf.TabIndex = 8;
            // 
            // textcep
            // 
            textcep.Location = new Point(237, 270);
            textcep.Name = "textcep";
            textcep.Size = new Size(308, 23);
            textcep.TabIndex = 9;
            // 
            // texttelefone
            // 
            texttelefone.Location = new Point(237, 314);
            texttelefone.Name = "texttelefone";
            texttelefone.Size = new Size(308, 23);
            texttelefone.TabIndex = 10;
            // 
            // textcelular
            // 
            textcelular.Location = new Point(237, 356);
            textcelular.Name = "textcelular";
            textcelular.Size = new Size(308, 23);
            textcelular.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(92, 73);
            label1.Name = "label1";
            label1.Size = new Size(139, 23);
            label1.TabIndex = 12;
            label1.Text = "\tNome Usuario\t:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(108, 112);
            label3.Name = "label3";
            label3.Size = new Size(123, 23);
            label3.TabIndex = 13;
            label3.Text = "Sobre Nome:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(70, 151);
            label4.Name = "label4";
            label4.Size = new Size(161, 23);
            label4.TabIndex = 14;
            label4.Text = "Data Aniversario:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(155, 192);
            label5.Name = "label5";
            label5.Size = new Size(76, 23);
            label5.TabIndex = 15;
            label5.Text = "Cidade:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(192, 235);
            label6.Name = "label6";
            label6.Size = new Size(39, 23);
            label6.TabIndex = 16;
            label6.Text = "UF:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(180, 267);
            label7.Name = "label7";
            label7.Size = new Size(51, 23);
            label7.TabIndex = 17;
            label7.Text = "CEP:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(139, 311);
            label8.Name = "label8";
            label8.Size = new Size(92, 23);
            label8.TabIndex = 18;
            label8.Text = "Telefone:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(153, 353);
            label9.Name = "label9";
            label9.Size = new Size(78, 23);
            label9.TabIndex = 19;
            label9.Text = "Celular:";
            // 
            // btnGravar
            // 
            btnGravar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGravar.Location = new Point(123, 411);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(175, 55);
            btnGravar.TabIndex = 20;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnlimpar
            // 
            btnlimpar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlimpar.Location = new Point(342, 411);
            btnlimpar.Name = "btnlimpar";
            btnlimpar.Size = new Size(175, 55);
            btnlimpar.TabIndex = 21;
            btnlimpar.Text = "Limpar";
            btnlimpar.UseVisualStyleBackColor = true;
            btnlimpar.Click += btnlimpar_Click;
            // 
            // btnFechar
            // 
            btnFechar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFechar.Location = new Point(557, 411);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(175, 55);
            btnFechar.TabIndex = 22;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // dtpNascimento
            // 
            dtpNascimento.Location = new Point(237, 151);
            dtpNascimento.Name = "dtpNascimento";
            dtpNascimento.Size = new Size(308, 23);
            dtpNascimento.TabIndex = 23;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(118, 50);
            label10.Name = "label10";
            label10.Size = new Size(113, 23);
            label10.TabIndex = 25;
            label10.Text = "cnpj ou cpf:";
            // 
            // txtcepf
            // 
            txtcepf.Location = new Point(237, 47);
            txtcepf.Name = "txtcepf";
            txtcepf.Size = new Size(308, 23);
            txtcepf.TabIndex = 26;
            // 
            // Cadastrarusuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 510);
            Controls.Add(txtcepf);
            Controls.Add(label10);
            Controls.Add(dtpNascimento);
            Controls.Add(btnFechar);
            Controls.Add(btnlimpar);
            Controls.Add(btnGravar);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textcelular);
            Controls.Add(texttelefone);
            Controls.Add(textcep);
            Controls.Add(textuf);
            Controls.Add(textcidade);
            Controls.Add(txtsobrenome);
            Controls.Add(txtusuario);
            Controls.Add(label2);
            Name = "Cadastrarusuario";
            Text = "Cadastrarusuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox txtusuario;
        private TextBox txtsobrenome;
        private TextBox textcidade;
        private TextBox textuf;
        private TextBox textcep;
        private TextBox texttelefone;
        private TextBox textcelular;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btnGravar;
        private Button btnlimpar;
        private Button btnFechar;
        private DateTimePicker dtpNascimento;
        private Label label10;
        private MaskedTextBox txtcepf;
    }
}