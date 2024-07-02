namespace SistemaVendas.Uteis;
using MySql.Data.MySqlClient;

public class DAL
{
    private static string Server = "localhost";
    private static string Database = "sistema_venda";
    private static string User = "root";
    private static string Password = "";
    private static string ConnectionString = $"Server={Server};Database={Database};Uis={User};Pwd={Password};Sslmode=none;Charset=utf8;";
    private static MySqlConnection Connection;

    public DAL()
    {
        Connection = new MySqlConnection(ConnectionString);
        Connection.Open();
    }


 }
