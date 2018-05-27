using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using TaskPlanApp.Persistence;
using Xamarin.Forms;

namespace TaskPlanApp.Model
{
    public class TaskDB
    {
        SQLiteAsyncConnection db { get; set; }

        TaskDB()
        {
            db = DependencyService.Get<ISQLiteDB>().GetConnection("taskdata.db3");
            db.CreateTableAsync<TaskItem>();
        }
    }

}
