using Microsoft.EntityFrameworkCore;
using System.Windows;
using trainer_companion.Database;
using trainer_companion.Navigation;
using trainer_companion.ViewModels;
using trainer_companion.ViewModels.Students;
using trainer_companion.Views.Students;

namespace trainer_companion
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override async void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            try
            {
                await using (var db = new AppDbContext())
                {
                    // Apply all pending migrations.
                    await db.Database.MigrateAsync();
                }

                // Only show the application after the database is ready.
                var navigator = new Navigator();
                var mvm = new MainViewModel(navigator);
                var window = new MainWindow { DataContext = mvm };

                navigator.GoTo(new MainScreenViewModel()); // Don't go to MainViewModel, go to MainScreenViewModel instead
                window.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Failed to initialize the database:\n\n{ex.Message}",
                    "Database Error",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);

                Shutdown(-1);
            }

            
        }
    }

}
