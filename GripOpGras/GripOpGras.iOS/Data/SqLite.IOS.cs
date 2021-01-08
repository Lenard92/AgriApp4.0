using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using GripOpGras.Data;
using Foundation;
using UIKit;
using GripOpGras.Data;
using Xamarin.Forms;
using GripOpGras.iOS.Data;

[assembly: Dependency(typeof(SqLite_IOS))]

namespace GripOpGras.iOS.Data
{
    public class SqLite_IOS : ISQLite
    {
        public SqLite_IOS() { }
        public SQLite.SQLiteConnection GetConnection()
        {
            var fileName = "Testdb.db3";
            var documentPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var libraryPath = Path.Combine(documentPath, "..", "Library");
            var path = Path.Combine(libraryPath, fileName);
            var connection = new SQLite.SQLiteConnection(path);
            return connection;
        }
    }
}