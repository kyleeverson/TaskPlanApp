using System;
using System.IO;

using SQLite;
using TaskPlanApp.Persistence;
using TaskPlanApp.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLiteDB))]

namespace TaskPlanApp.Droid
{
    public class SQLiteDB : ISQLiteDB
    {
        public SQLiteAsyncConnection GetConnection(string name)
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(documentsPath, name);

            return new SQLiteAsyncConnection(path);
        }
    }
}