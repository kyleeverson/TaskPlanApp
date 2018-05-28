using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using TaskPlanApp.Model;
using TaskPlanApp.Model.Task;

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
            Initialize();
        }

        private async void Initialize()
        {
            List<TaskItem> list = await TaskManager.GetAll();
            foreach(TaskItem item in list) {
                var taskModel = new TaskViewModel(item);
                _items.Add(taskModel);
            }
            RaisePropertyChanged("Items");
        }

        public void AddNewItem(TaskViewModel vm)
        {
            _items.Add(vm);
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
