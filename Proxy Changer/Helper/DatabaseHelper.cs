using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Proxy_Changer.Connection {

    public class DatabaseHelper {
        private string connectionString;

        public DatabaseHelper(string databasePath) {
            connectionString = $"Data Source={databasePath};Version=3;";
        }

        public void InitializeDatabase() {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString)) {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand("CREATE TABLE IF NOT EXISTS ProxySettings (Id INTEGER PRIMARY KEY, ProxyAddress TEXT)", connection)) {
                    command.ExecuteNonQuery();
                }
            }
        }

        public string LoadProxyAddress() {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString)) {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand("SELECT ProxyAddress FROM ProxySettings WHERE Id = 1", connection)) {
                    object result = command.ExecuteScalar();
                    if (result != null) {
                        return result.ToString();
                    }
                }
            }
            return string.Empty;
        }

        public void SaveProxyAddress(string proxyAddress) {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString)) {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand("INSERT OR REPLACE INTO ProxySettings (Id, ProxyAddress) VALUES (1, @ProxyAddress)", connection)) {
                    command.Parameters.AddWithValue("@ProxyAddress", proxyAddress);
                    command.ExecuteNonQuery();
                }
            }
        }
    }

}
