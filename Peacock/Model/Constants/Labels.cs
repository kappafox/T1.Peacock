
namespace Peacock.Model.Constants
{
    using Peacock.Model.Utility;
    using System.Linq;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Input;
    using System.Windows.Media;
    using System.Windows.Media.Effects;

    public static class Labels
    {
        private const string SectionTitleColour = "#b65819";

        public static TextBox SectionTitle()
        {
            TextBox l = new TextBox();
            l.FontFamily = Fonts.OpenSans;
            l.Foreground = EasyColour.BrushFromHex(SectionTitleColour);
            l.FontSize = Fonts.Size.SectionTitle;
            l.Text = "Section Title";
            l.Padding = new Thickness(11, 15, 0, 0);
            l.BorderBrush = null;
            l.BorderThickness = new Thickness(0, 0, 0, 0);
            //l.IsEnabled = false;

            l.HorizontalAlignment = HorizontalAlignment.Left;

            l.MouseDoubleClick += clix;
            l.KeyUp += StopEditingTextBox;
            //l.AcceptsReturn = true;
            l.LostFocus += TextBoxLostFocus;
            l.IsReadOnly = true;

            return l;
        }

        public static TextBox SuperGridTitle()
        {
            var label = new TextBox();
            label.FontFamily = Fonts.OpenSans;
            label.FontSize = Fonts.Size.SuperGridHeader;
            label.Foreground = EasyColour.BrushFromHex("#34282C");
            label.Text = "Table Header";
            label.VerticalAlignment = VerticalAlignment.Center;
            label.Background = null;
            label.BorderBrush = null;
            label.Padding = new Thickness(5, 0, 0, 0);
            label.BorderThickness = new Thickness(0, 0, 0, 0);

            RenderOptions.SetBitmapScalingMode(label, BitmapScalingMode.NearestNeighbor);
            TextOptions.SetTextFormattingMode(label, TextFormattingMode.Display);
            Setter effectSetter = new Setter();
            effectSetter.Property = ScrollViewer.EffectProperty;
            effectSetter.Value = new DropShadowEffect
            {
                ShadowDepth = 1,
                Direction = 270,
                Color = Colors.White,
                Opacity = 1,
                BlurRadius = 0.0
            };
            Style dropShadowScrollViewerStyle = new Style(typeof(ScrollViewer));
            dropShadowScrollViewerStyle.Setters.Add(effectSetter);

            label.Resources.Add(typeof(ScrollViewer), dropShadowScrollViewerStyle);

            label.IsReadOnly = true;
            label.MouseDoubleClick += clix;
            label.KeyUp += StopEditingTextBox;
            label.LostFocus += TextBoxLostFocus;


            return label;
        }

        public static void clix(object origin, RoutedEventArgs args)
        {
            var tbox = origin as TextBox;

            //tbox.IsEnabled = !tbox.IsEnabled;
            //tbox.Text = "Clicked";

            tbox.IsReadOnly = false;

            tbox.Background = new SolidColorBrush(Colors.LightBlue);
        }

        public static void TextBoxLostFocus(object origin, RoutedEventArgs args)
        {
            var box = origin as TextBox;
            box.IsReadOnly = true;
            box.Background = null;
        }

        public static void StopEditingTextBox(object origin, KeyEventArgs args)
        {
            if (args.Key == Key.Return)
            {
                var tbox = origin as TextBox;

                tbox.IsReadOnly = true;
                tbox.Background = null;
                Keyboard.ClearFocus();

            }
            else
            {
                if (args.Key == Key.Tab)
                {
                    var tbox = origin as TextBox;

                    tbox.IsReadOnly = true;
                    tbox.Background = null;
                    Keyboard.ClearFocus();

                    var row = Grid.GetRow(tbox);
                    var col = Grid.GetColumn(tbox);

                    var grid = tbox.Parent as Grid;

                    var nextbox = grid.Children.Cast<UIElement>().FirstOrDefault(i => Grid.GetColumn(i) == (col + 1) && Grid.GetRow(i) == row);

                    if (nextbox != null)
                    {
                        var next = nextbox as TextBox;

                        if (next != null)
                        {
                            Keyboard.Focus(next);
                            next.IsReadOnly = false;
                        }
                    }
                }
            }

        }
    }
}
