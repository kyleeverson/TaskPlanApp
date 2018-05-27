using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace TaskPlanApp.Model
{
    public class TaskItem
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }

        public string itemName { get; set; }
        public DateTime startDate { get; set; }
        public Boolean completed { get; set; }

        public TaskItem()
        {
            id = 0;
            itemName = "";
            startDate = DateTime.Today;
            completed = false;
        }
    }

}
