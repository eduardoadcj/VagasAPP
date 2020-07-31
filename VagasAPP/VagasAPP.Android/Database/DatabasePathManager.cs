using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using VagasAPP.Database;
using VagasAPP.Droid.Database;

[assembly: Xamarin.Forms.Dependency(typeof(DatabasePathManager))]
namespace VagasAPP.Droid.Database {
    public class DatabasePathManager : IDatabasePath {
        public string GetPath(string databaseName) {
            var dbPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            return System.IO.Path.Combine(dbPath, databaseName);
        }
    }
}