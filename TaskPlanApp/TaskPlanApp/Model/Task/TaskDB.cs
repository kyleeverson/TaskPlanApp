using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TaskPlanApp.Persistence;
using Xamarin.Forms;

namespace TaskPlanApp.Model
{
    public class TaskDB
    {
        public SQLiteAsyncConnection db { get; set; }

        public TaskDB()
        {
            db = DependencyService.Get<ISQLiteDB>().GetConnection("taskdata.db3");
            InitializeDB();
        }

        async void InitializeDB()
        {
            await db.CreateTableAsync<TaskItem>();
        }

        public async Task<int> SaveItem(TaskItem item)
        {
            if (item.id != 0) {
                await db.UpdateAsync(item);
            } else {
                int newid = await db.InsertAsync(item);
            }
            return item.id;
        }
    }
}
