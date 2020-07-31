using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VagasAPP.Database;
using VagasAPP.UWP.Database;
using Windows.Storage;

[assembly:Xamarin.Forms.Dependency(typeof(DatabasePathManager))]
namespace VagasAPP.UWP.Database {
    public class DatabasePathManager : IDatabasePath {
        public string GetPath(string databaseName) {
            var usableDirectory = ApplicationData.Current.LocalFolder.Path;
            return System.IO.Path.Combine(usableDirectory, databaseName);
        }
    }
}
