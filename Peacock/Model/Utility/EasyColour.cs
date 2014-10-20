
namespace Peacock.Model.Utility
{
    using System.Windows.Media;

    public static class EasyColour
    {
        private static BrushConverter BConverter = new BrushConverter();
        public static Brush BrushFromHex(string hex)
        {
            return BConverter.ConvertFrom(hex) as Brush;
        }

        public static Brush LinearGradientBrushFromHex(string gradientStart, string gradientEnd, double angle)
        {
            var start = (Color)ColorConverter.ConvertFromString(gradientStart);
            var end = (Color)ColorConverter.ConvertFromString(gradientEnd);
            var brush = new LinearGradientBrush(start, end, angle);

            return brush;
        }
    }
}
