
namespace Peacock.Model.Fabricator.Templates
{
    using Peacock.Model.Constants;
    using Peacock.Model.Utility;
    using System.Windows;
    using System.Windows.Controls;

    public static class BorderFactory
    {
        public static Border BevelBottom(string colour)
        {
            var border = new Border();
            border.BorderBrush = EasyColour.BrushFromHex(colour);
            border.BorderThickness = new Thickness(DisplayConstants.Dimensions.Borders.BevelBorderThickness);
            border.Height = DisplayConstants.Dimensions.Borders.BevelBorderThickness;
            border.VerticalAlignment = VerticalAlignment.Bottom;

            return border;
        }

        public static Border BevelRight(string colour)
        {
            var border = new Border();
            border.BorderBrush = EasyColour.BrushFromHex(colour);
            border.BorderThickness = new Thickness(DisplayConstants.Dimensions.Borders.BevelBorderThickness);
            border.Width = DisplayConstants.Dimensions.Borders.BevelBorderThickness;
            border.HorizontalAlignment = HorizontalAlignment.Right;

            return border;
        }

        public static Border BevelTop(string colour)
        {
            var border = new Border();
            border.BorderBrush = EasyColour.BrushFromHex(colour);
            border.BorderThickness = new Thickness(DisplayConstants.Dimensions.Borders.BevelBorderThickness);
            border.Height = DisplayConstants.Dimensions.Borders.BevelBorderThickness;
            border.VerticalAlignment = VerticalAlignment.Top;

            return border;
        }

        public static Border BevelFull(string colour)
        {
            var border = new Border();
            border.BorderBrush = EasyColour.BrushFromHex(colour);
            border.BorderThickness = new Thickness(DisplayConstants.Dimensions.Borders.BevelBorderThickness);
            border.HorizontalAlignment = HorizontalAlignment.Stretch;
            border.VerticalAlignment = VerticalAlignment.Stretch;

            return border;
        }

        public static UIElement BevelLeft(string colour)
        {
            var border = new Border();
            border.BorderBrush = EasyColour.BrushFromHex(colour);
            border.BorderThickness = new Thickness(DisplayConstants.Dimensions.Borders.BevelBorderThickness);
            border.Width = DisplayConstants.Dimensions.Borders.BevelBorderThickness;
            border.HorizontalAlignment = HorizontalAlignment.Left;

            return border;
        }
    }
}
