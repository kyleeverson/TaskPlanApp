using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace TaskPlanApp.Persistence
{
    interface ISQLiteDB
    {
        SQLiteAsyncConnection GetConnection(string name);
    }
}
