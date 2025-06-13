using MySql.Data.MySqlClient;

public class ConexaoMySQL
{
    private static string servidor = "127.0.0.1";
    private static string bancoDados = "biblioteca";
    private static string usuario = "root"; // ou seu usuário
    private static string senha = ""; // ou sua senha
    private static string porta = "3306";

    private static string stringConexao = $"Server={servidor};Port={porta};Database={bancoDados};Uid={usuario};Pwd={senha};";

    public static MySqlConnection ObterConexao()
    {
        return new MySqlConnection(stringConexao);
    }
}
