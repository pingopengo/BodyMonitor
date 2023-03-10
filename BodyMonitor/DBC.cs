namespace BodyMonitor;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;


public class DBC
{
    private readonly IConfiguration _configuration;

    public DBC()
    {
        var builder = new ConfigurationBuilder()
            .AddUserSecrets<DBC>();
        _configuration = builder.Build();
    }

    private string? connect()
    {
        string? connString = _configuration["ConnectionString"];
        return connString;
    }
    
    public static void LogWarning(Warning warning)
    {
        var db = new DBC();
        string? connString = db.connect();
        
        if (connString != null)
        {
            var connection = new MySqlConnection(connString);
            
                try
                {
                    connection.Open();

                    Console.WriteLine("Connection opened");

                    string sql = "INSERT INTO warningLog (message, is_valid, priority) VALUES (@message, @is_valid, @priority)";
                    using (var command = new MySqlCommand(sql, connection))
                    {
                        Console.WriteLine($"Parameters: message={warning.message}, isValid={warning.isValid}, priority={warning.priority}");

                        command.Parameters.AddWithValue("@message", warning.message);
                        command.Parameters.AddWithValue("@is_valid", warning.isValid);
                        command.Parameters.AddWithValue("@priority", warning.priority);

                        int rowsAffected = command.ExecuteNonQuery();

                        Console.WriteLine($"{rowsAffected} rows inserted.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                finally
                {
                    connection.Close();
                    Console.WriteLine("Connection closed");
                }
        }
    }
}

