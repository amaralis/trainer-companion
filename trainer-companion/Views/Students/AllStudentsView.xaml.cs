using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Diagnostics;

namespace trainer_companion.Views.Students
{
    /// <summary>
    /// Interaction logic for AllStudentsView.xaml
    /// </summary>
    public partial class AllStudentsView : UserControl
    {
        public AllStudentsView()
        {
            InitializeComponent();
            DataContext = new ViewModels.Students.AllStudentsViewModel();
            Loaded += AllStudentsView_Loaded;
        }

        private async void AllStudentsView_Loaded(object sender, RoutedEventArgs e)
        {
            if (DataContext is ViewModels.Students.AllStudentsViewModel viewModel)
            {
                await viewModel.InitializeAsync();
            }
        }
    }
}
