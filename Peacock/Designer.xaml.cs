using System.Windows;

namespace Peacock
{
    using Peacock.Model.Fabricator;

    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Designer : Window
    {
        public Designer()
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
