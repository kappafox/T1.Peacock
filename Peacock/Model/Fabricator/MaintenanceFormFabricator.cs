
namespace Peacock.Model.Fabricator
{
    using Peacock.Model.Constants;
    using Peacock.Model.Fabricator.Templates;
    using Peacock.Model.Utility;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Media;

    public class MaintenanceFormFabricator : Fabricator
    {
        private const int ColumnCount = 2;

        public override Window Fabricate()
        {
            var window = new Window();

            window.Height = DisplayConstants.Dimensions.Forms.WindowHeight;
            window.Width = DisplayConstants.Dimensions.Forms.WindowWidth;
            window.SnapsToDevicePixels = true;

            var bc = new BrushConverter();

            var mgrid = new Grid();
            //mgrid.ShowGridLines = true;
            mgrid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(DisplayConstants.Dimensions.Forms.SectionSelectionPaneWidth) });
            mgrid.ColumnDefinitions.Add(new ColumnDefinition());
            mgrid.Background = EasyColour.BrushFromHex(DisplayConstants.Colours.Forms.StandardBackgroundGrey);


            CreateBanner(mgrid);
            CreateMainActionBar(mgrid);
            CreateFormControlBar(mgrid);

            CreateSectionSelectionPane(mgrid);

            CreateSection(mgrid);

            window.Content = mgrid;

            return window;
        }

        private void CreateBanner(Grid layout)
        {

            var bar = new DockPanel();
            bar.Background = EasyColour.BrushFromHex(DisplayConstants.Colours.Forms.BannerBackgroundBlack);

            var row = new RowDefinition();
            row.Height = new GridLength(DisplayConstants.Dimensions.Forms.BannerHeight);

            Grid.SetRow(bar, 0);
            Grid.SetColumn(bar, 0);
            Grid.SetColumnSpan(bar, ColumnCount);

            layout.RowDefinitions.Add(row);
            layout.Children.Add(bar);
        }

        private void CreateFormControlBar(Grid layout)
        {
            var borderTop = BorderFactory.BevelTop(DisplayConstants.Colours.Borders.BevelBorderLight);
            var borderBot = BorderFactory.BevelBottom(DisplayConstants.Colours.Borders.BevelBorderDark);

            var formActionBar = new DockPanel();
            formActionBar.Background = EasyColour.BrushFromHex(DisplayConstants.Colours.Forms.StandardBackgroundGrey);

            var row = new RowDefinition();
            row.Height = new GridLength(DisplayConstants.Dimensions.Forms.FormControlBarHeight);

            layout.RowDefinitions.Add(row);
            Grid.SetRow(formActionBar, 2);
            Grid.SetColumn(formActionBar, 0);
            Grid.SetColumnSpan(formActionBar, ColumnCount);

            layout.Children.Add(formActionBar);

            Grid.SetRow(borderBot, 2);
            Grid.SetColumn(borderBot, 0);
            Grid.SetColumnSpan(borderBot, ColumnCount);

            Grid.SetRow(borderTop, 2);
            Grid.SetColumn(borderTop, 0);
            Grid.SetColumnSpan(borderTop, ColumnCount);

            layout.Children.Add(borderTop);
            layout.Children.Add(borderBot);
        }

        private void CreateMainActionBar(Grid layout)
        {
            var border = BorderFactory.BevelBottom(DisplayConstants.Colours.Borders.BevelBorderDark);

            var bar = new DockPanel();
            bar.Background = EasyColour.BrushFromHex(DisplayConstants.Colours.Forms.MainActionBarBackgroundGrey);

            var row = new RowDefinition();
            row.Height = new GridLength(DisplayConstants.Dimensions.Forms.MainActionBarHeight);

            Grid.SetRow(border, 1);
            Grid.SetColumn(border, 0);
            Grid.SetColumnSpan(border, ColumnCount);

            Grid.SetRow(bar, 1);
            Grid.SetColumn(bar, 0);
            Grid.SetColumnSpan(bar, ColumnCount);

            layout.RowDefinitions.Add(row);
            layout.Children.Add(bar);
            layout.Children.Add(border);
        }

        private void CreateSectionSelectionPane(Grid layout)
        {
            var row = new RowDefinition();
            row.Height = GridLength.Auto;
            layout.RowDefinitions.Add(row);

            var border = BorderFactory.BevelRight(DisplayConstants.Colours.Borders.BevelBorderDark);
            Grid.SetRow(border, 3);
            Grid.SetColumn(border, 0);

            var selectionPane = new StackPanel();
            selectionPane.Background = EasyColour.BrushFromHex(DisplayConstants.Colours.Forms.StandardBackgroundGrey);
            selectionPane.Height = 900;
            Grid.SetRow(selectionPane, 3);
            Grid.SetColumn(selectionPane, 0);

            for (int i = 0; i < 4; i++)
            {
                CreateSectionSelector(selectionPane);
            }

            layout.Children.Add(selectionPane);
            layout.Children.Add(border);

        }

        private void CreateSectionSelector(StackPanel stackPanel)
        {

            var fborder = BorderFactory.BevelTop(DisplayConstants.Colours.Borders.BevelBorderLight);
            stackPanel.Children.Add(fborder);

            var panel = new DockPanel();

            panel.Height = DisplayConstants.Dimensions.Forms.SectionSelectorHeight;


            stackPanel.Children.Add(panel);

            var border = BorderFactory.BevelBottom(DisplayConstants.Colours.Borders.BevelBorderDark);
            stackPanel.Children.Add(border);
        }

        private void CreateSection(Grid parentGrid)
        {
            var contentGrid = new RdpSectionFabricator().Fabricate();
            Grid.SetRow(contentGrid, 3);
            Grid.SetColumn(contentGrid, 1);

            parentGrid.Children.Add(contentGrid);
        }
    }
}
