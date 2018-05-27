using System;
using SQLite;
using TaskPlanApp.Persistence;
using System.IO;
using Xamarin.Forms;
using TaskPlanApp.iOS.Persistence;

[assembly: Dependency(typeof(SQLiteDb))]

namespace TaskPlanApp.iOS.Persistence
{
    public class SQLiteDb : ISQLiteDB
    {
        public SQLiteAsyncConnection GetConnection(string name)
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(documentsPath, name);

            return new SQLiteAsyncConnection(path);
        }
    }
}