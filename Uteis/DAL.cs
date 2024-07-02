namespace SistemaVendas.Uteis;
using MySql.Data.MySqlClient;
using System.Data;
public class DAL
{
    private static string Server = "localhost";
    private static string Database = "sistema_venda";
    private static string User = "root";
    private static string Password = "ienh";
    private static string ConnectionString = $"Server={Server};Database={Database};Uid={User};Pwd={Password};Sslmode=none;Charset=utf8;";
    private static MySqlConnection Connection;

    public DAL()
    {
        Connection = new MySqlConnection(ConnectionString);
        Connection.Open();
    }

    //Espera um parâmetro do tipo string contendo um comando do tipo SELECT
    public DataTable RetDataTable(string sql)
    {
        DataTable data = new DataTable();
        MySqlCommand Command = new MySqlCommand(sql, Connection);
        MySqlDataAdapter da = new MySqlDataAdapter(Command);
        da.Fill(data);
        return data;
    }
    //Espera um parâmetro do tipo string contendo um comando do tipo INSERT, UPDATE, DELETE
    public void ExecutarComandoSQL(string sql)
    {
        MySqlCommand Command = new MySqlCommand(sql, Connection);
        Command.ExecuteNonQuery();
    }
 }
