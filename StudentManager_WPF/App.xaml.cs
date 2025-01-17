using System.Configuration;
using System.Data;
using System.Windows;
using StudentManager_WPF.Stores;
using StudentManager_WPF.ViewModels;

namespace StudentManager_WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly SelectedStudentStore _selectedStudentStore;

        public App()
        {
            _selectedStudentStore = new SelectedStudentStore();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new StudentInformationViewModel(_selectedStudentStore)
            };
            MainWindow.Show();

            base.OnStartup(e);
        }
    }

}
