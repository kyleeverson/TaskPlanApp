using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using TaskPlanApp.Model;
using TaskPlanApp.Model.Task;

namespace TaskPlanApp.ViewModels
{
    public class TaskViewModel : INotifyPropertyChanged
    {
        private TaskItem _task;

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

        public DateTime StartDate {
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

        public TaskViewModel(TaskItem t)
        {
            _task = t;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
#pragma warning disable CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
            TaskManager.UpdateItem(_task);
#pragma warning restore CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
        }
    }
}
