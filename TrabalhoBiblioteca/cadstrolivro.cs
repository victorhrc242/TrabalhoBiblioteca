using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoBiblioteca
{
    public partial class cadstrolivro : Form
    {
        public cadstrolivro()
        {
            InitializeComponent();
        }

        private void cadstrolivro_Load(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            txttitulo.Clear();
            txtAutor.Clear();
            txttitulo.Focus();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txttitulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAutor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string titulo = txttitulo.Text.Trim();
            string autor = txtAutor.Text.Trim();

            if (string.IsNullOrEmpty(titulo) || string.IsNullOrEmpty(autor))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conexao = ConexaoMySQL.ObterConexao())
                {
                    conexao.Open();

                    string sql = "INSERT INTO livro (titulo, autor) VALUES (@titulo, @autor)";
                    using (var comando = new MySqlCommand(sql, conexao))
                    {
                        comando.Parameters.AddWithValue("@titulo", titulo);
                        comando.Parameters.AddWithValue("@autor", autor);
                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Livro cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpa os campos
                txttitulo.Clear();
                txtAutor.Clear();
                txttitulo.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar livro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
