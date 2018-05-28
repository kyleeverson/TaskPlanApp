using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TaskPlanApp.Model;
using TaskPlanApp.ViewModels;
using TaskPlanApp.Model.Task;

namespace TaskPlanApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TaskListView : ContentPage
    {
        TaskListViewModel model;

        public TaskListView()
        {
            model = new TaskListViewModel();

            InitializeComponent();

            ToolbarItems.Add(new ToolbarItem("Add", null, async () => {
                await AddTask();
            }));

            BindingContext = model;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            TaskViewModel model = e.Item as TaskViewModel;
            TaskPage page = new TaskPage(model);

            await Navigation.PushAsync(page);
        }

        async Task<int> AddTask()
        {
            TaskItem item = new TaskItem();
            await TaskManager.UpdateItem(item);
            return 0;
        }

    }
}
