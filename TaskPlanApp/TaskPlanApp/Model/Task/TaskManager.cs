using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TaskPlanApp.Model.Task
{
    class TaskManager
    {
        TaskDB _db = null;
        private static TaskManager _me;

        static TaskManager()
        {
            if (_me == null) {
                _me = new TaskManager();
            }
        }

        public TaskManager()
        {
            _db = new TaskDB();
        }

        public static async Task<List<TaskItem>> GetAll()
        {
            List<TaskItem> list = await _me._db.db.QueryAsync<TaskItem>("SELECT * FROM taskitem");

            return list;
        }
    }
}
