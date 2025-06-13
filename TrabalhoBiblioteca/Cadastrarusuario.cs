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
    public partial class Cadastrarusuario : Form
    {
        public Cadastrarusuario()
        {
            InitializeComponent();
        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string idUsuario = txtcepf.Text.Replace(".", "").Replace("-", "").Replace("/", "").Trim(); // limpar máscara
            string nome = txtusuario.Text.Trim();
            string sobrenome = txtsobrenome.Text.Trim();
            string dataNascimento = dtpNascimento.Value.ToString("yyyy-MM-dd");
            string cidade = textcidade.Text.Trim();
            string uf = textuf.Text.Trim();
            string cep = textcep.Text.Trim();
            string telefone = texttelefone.Text.Trim();
            string celular = textcelular.Text.Trim();
            string dataCadastro = DateTime.Now.ToString("yyyy-MM-dd");

            // Verifica se CPF ou CNPJ é válido
            if (!(idUsuario.Length == 11 || idUsuario.Length == 14))
            {
                MessageBox.Show("Informe um CPF (11 dígitos) ou CNPJ (14 dígitos) válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(sobrenome) || string.IsNullOrEmpty(cidade)
                || string.IsNullOrEmpty(uf) || string.IsNullOrEmpty(cep) || string.IsNullOrEmpty(telefone)
                || string.IsNullOrEmpty(celular))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conexao = ConexaoMySQL.ObterConexao())
                {
                    conexao.Open();

                    string sql = @"INSERT INTO usuario 
                (idUsuario, nomeUsuario, sobrenomeUsuario, dataNascimento, cidade, UF, cep, telefone, celular, dataCadastro) 
                VALUES 
                (@idUsuario, @nome, @sobrenome, @dataNascimento, @cidade, @uf, @cep, @telefone, @celular, @dataCadastro)";

                    using (var comando = new MySqlCommand(sql, conexao))
                    {
                        comando.Parameters.AddWithValue("@idUsuario", idUsuario);
                        comando.Parameters.AddWithValue("@nome", nome);
                        comando.Parameters.AddWithValue("@sobrenome", sobrenome);
                        comando.Parameters.AddWithValue("@dataNascimento", dataNascimento);
                        comando.Parameters.AddWithValue("@cidade", cidade);
                        comando.Parameters.AddWithValue("@uf", uf);
                        comando.Parameters.AddWithValue("@cep", cep);
                        comando.Parameters.AddWithValue("@telefone", telefone);
                        comando.Parameters.AddWithValue("@celular", celular);
                        comando.Parameters.AddWithValue("@dataCadastro", dataCadastro);

                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Perfil cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpar campos
                txtcepf.Clear();
                txtusuario.Clear();
                txtsobrenome.Clear();
                textcidade.Clear();
                textuf.Clear();
                textcep.Clear();
                texttelefone.Clear();
                textcelular.Clear();
                dtpNascimento.Value = DateTime.Today;
                txtusuario.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar perfil: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtcepf.Clear();
            txtusuario.Clear();
            txtsobrenome.Clear();
            dtpNascimento.Value = DateTime.Today;
            textcidade.Clear();
            textuf.Clear();
            textcep.Clear();
            texttelefone.Clear();
            textcelular.Clear();
            txtusuario.Focus();
        }


        private void btnFechar_Click(object sender, EventArgs e)
        {

        }

        private void txtcepf_TextChanged(object sender, EventArgs e)
        {
            string texto = txtcepf.Text.Replace(".", "").Replace("-", "").Replace("/", "").Trim();

            if (texto.Length <= 11)
            {
                txtcepf.Mask = "000.000.000-00"; // CPF
            }
            else
            {
                txtcepf.Mask = "00.000.000/0000-00"; // CNPJ
            }
        }
    }
}
