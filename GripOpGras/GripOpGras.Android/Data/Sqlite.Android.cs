﻿using System;
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
using GripOpGras.Models;
using GripOpGras.Views.Menu;
using System.IO;
using Xamarin.Forms;
using GripOpGras.Droid.Data;
using SQLite;

[assembly: Dependency(typeof(SqLite_Android))]


namespace GripOpGras.Droid.Data
{
    public class SqLite_Android : ISQLite  
    {
        public SqLite_Android() { }
        public SQLite.SQLiteConnection GetConnection()
        {

        var sqliteFileName = "TestDB.db3";
        string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
        var path = Path.Combine(documentsPath, sqliteFileName);
        var conn = new SQLite.SQLiteConnection(path);

        return conn;
        
        }
    }
}