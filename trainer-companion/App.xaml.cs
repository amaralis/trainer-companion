using Microsoft.EntityFrameworkCore;
using System.Windows;
using trainer_companion.Database;

namespace trainer_companion
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override async void OnStartup(StartupEventArgs e)
        {
            //base.OnStartup(e);

            //try
            //{
            //    await using (var db = new AppDbContext())
            //    {
            //        // Apply all pending migrations.
            //        await db.Database.MigrateAsync();
            //    }

            //    // Only show the application after the database is ready.
            //    var mainWindow = new MainWindow();
            //    mainWindow.Show();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(
            //        $"Failed to initialize the database:\n\n{ex.Message}",
            //        "Database Error",
            //        MessageBoxButton.OK,
            //        MessageBoxImage.Error);

            //    Shutdown(-1);
            //}
        }
    }

}
