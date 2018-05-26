using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using TaskPlanApp.Model;

namespace TaskPlanApp.ViewModels
{
    class TaskListViewModel : INotifyPropertyChanged
    {
        ObservableCollection<TaskViewModel> _items;
        public ObservableCollection<TaskViewModel> Items {
            get {
                return _items;
            }
            set {
                _items = value;
                RaisePropertyChanged("Items");
            }
        }

        public TaskListViewModel()
        {
            _items = new ObservableCollection<TaskViewModel>();

            var _task = new TaskItem {
                itemName = "Item #1",
                completed = true,
                startDate = DateTime.Parse("05/25/2018 8:00AM")
            };
            var taskModel = new TaskViewModel(_task);
            _items.Add(taskModel);

            var _task2 = new TaskItem {
                itemName = "Item #2",
                completed = true,
                startDate = DateTime.Parse("05/25/2018 9:00AM")
            };
            var taskModel2 = new TaskViewModel(_task2);
            _items.Add(taskModel2);

            var _task3 = new TaskItem {
                itemName = "Item #3",
                completed = true,
                startDate = DateTime.Parse("05/25/2018 10:00AM")
            };
            var taskModel3 = new TaskViewModel(_task3);
            _items.Add(taskModel3);

            RaisePropertyChanged("Items");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propName)
        {
            if (PropertyChanged != null) {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }

    }
}
