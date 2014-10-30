
namespace Peacock.Model.Utility
{
    using System.Windows;
    using System.Windows.Controls;

    public static class EasyLayout
    {
        public static void SetPosition(Grid grid, UIElement element, int row, int col)
        {
            Grid.SetRow(element, row);
            Grid.SetColumn(element, col);
            grid.Children.Add(element);
        }
    }
}
