using System.Windows;

namespace Peacock
{
    using Peacock.Model.Fabricator;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var fab = new MaintenanceFormFabricator();
            var window = fab.Fabricate();

            window.Show();
        }
    }
}
