using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using VagasAPP.Database;
using VagasAPP.iOS.Database;

[assembly:Xamarin.Forms.Dependency(typeof(DatabasePathManager))]
namespace VagasAPP.iOS.Database {
    public class DatabasePathManager : IDatabasePath {

        public string GetPath(string databaseName) {
            var useableDir = System.IO.Path.Combine(
                System.Environment.GetFolderPath(
                    System.Environment.SpecialFolder.Personal), "..", "Library");
            return System.IO.Path.Combine(useableDir, databaseName);
        }

    }
}