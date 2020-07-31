using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace VagasAPP.Database {
    public class Connection {

        private const string DATABASE_NAME = "data.sqlite";

        private static SQLiteConnection _connection;
        
        private static void Open() {
            var dep = DependencyService.Get<IDatabasePath>();
            string path = dep.GetPath(DATABASE_NAME);
            _connection = new SQLiteConnection(path);
        }

        public static SQLiteConnection Get() {
            if (_connection == null)
                Connection.Open();
            return _connection;
        }

        public static void Close() {
            _connection.Close();
            _connection = null;
        }

    }
}
