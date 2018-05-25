using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using TaskPlanApp.Model;

namespace TaskPlanApp.ViewModels
{
    class TaskViewModel
    {
        private Task _task;

        public string Name
        {
            get {
                return _task.itemName;
            }
            set {
                _task.itemName = value;
                RaisePropertyChanged("Name");
            }
        }

        public string StartDate {
            get {
                return _task.startDate;
            }
            set {
                _task.startDate = value;
                RaisePropertyChanged("StartDate");
            }
        }

        public Boolean IsCompleted {
            get {
                return _task.completed;
            }
            set {
                _task.completed = value;
                RaisePropertyChanged("IsCompleted");
            }
        }

        public TaskViewModel()
        {
            _task = new Task {
                itemName = "This is the first item",
                completed = false,
                startDate = "2018 May 24"
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }
    }
}
