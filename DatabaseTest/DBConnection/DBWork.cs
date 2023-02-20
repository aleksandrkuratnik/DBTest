using System.Data;
using Aquality.Selenium.Browsers;
using DatabaseTest.Util;
using MySql.Data.MySqlClient;

namespace DatabaseTest.DBConnection
{
    internal class DBWork
    {
        private static readonly string password = FileReader.GetPassword();
        private static readonly string connectionString =
            $"server={TestConfigManager.testConfig.Server};user={TestConfigManager.testConfig.User};" +
            $"database={TestConfigManager.testConfig.Database};port={TestConfigManager.testConfig.Port};" +
            $"password=" + password;

        private static readonly MySqlConnection connection = new(connectionString);

        public static void Connect()
        {
            try
            {
                connection.Open();
                AqualityServices.Logger.Info("Successful connection");
            }
            catch (InvalidOperationException)
            {
                AqualityServices.Logger.Info("Failed connection");
            }
        }

        public static DataTable SendRequest(string sqlRequest)
        {
            using (connection)
            {
                Connect();
                MySqlCommand command = new MySqlCommand(sqlRequest, connection);
                MySqlDataReader sqlReader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(sqlReader);
                return dataTable;
            }
        }
    }
}
