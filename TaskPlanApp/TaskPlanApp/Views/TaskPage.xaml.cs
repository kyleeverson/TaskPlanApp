using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskPlanApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TaskPlanApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TaskPage : ContentPage
	{
        TaskViewModel viewModel;
		public TaskPage (TaskViewModel viewModel)
		{
			InitializeComponent ();
            BindingContext = viewModel;
            viewModel.RaisePropertyChanged("StartDate");
        }
    }
}