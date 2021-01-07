using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using GripOpGras.Data;
using System.IO;
using Xamarin.Forms;
using GripOpGras.Droid.Data;

[assembly: Dependency(typeof(SQLite_Android))]


namespace GripOpGras.Droid.Data
{
    class SQLite_Android : lSQlite
    {
        public SQLite_Android() { }
        public lSQlite.SQLiteConnection GetConnection()
        {

        var sqliteFileName = "TestDB.db3";
        string = documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
        var path = Path.Combine(documentsPath, sqliteFileName);
        var conn = new SQLitePCL.SQLiteConnection(path);

        return conn;
        }
    }
}