
namespace Peacock.Model.Fabricator
{
    using Peacock.Model.Constants;
    using Peacock.Model.Fabricator.Templates;
    using Peacock.Model.Utility;
    using System.Windows;
    using System.Windows.Controls;

    public class RdpSectionFabricator
    {
        public Grid Fabricate()
        {
            var contentGrid = new Grid();
            contentGrid.Background = EasyColour.BrushFromHex(DisplayConstants.Colours.Forms.PanelBackgroundWhite);

            // Title Bar : Row 0
            var row = new RowDefinition();
            row.Height = new GridLength(DisplayConstants.Dimensions.Forms.RdpSection.TitleBarHeight);
            contentGrid.RowDefinitions.Add(row);

            // Header Bar : Row 1
            row = new RowDefinition();
            row.Height = new GridLength(DisplayConstants.Dimensions.Forms.RdpSection.HeaderBarHeight);
            contentGrid.RowDefinitions.Add(row);

            var panel = new DockPanel();
            panel.Background = EasyColour.BrushFromHex(DisplayConstants.Colours.Forms.StandardBackgroundGrey);

            var thick = new Thickness(DisplayConstants.Dimensions.Forms.RdpSection.PaddingLeft, 0, DisplayConstants.Dimensions.Forms.RdpSection.PaddingRight, 0);
            panel.Margin = thick;
            Grid.SetRow(panel, 1);

            // Action Bar : Row 2
            CreateActionBar(contentGrid);

            contentGrid.Children.Add(panel);

            // Content Grid : Row 3
            row = new RowDefinition();
            contentGrid.RowDefinitions.Add(row);
            CreateSuperGrid(contentGrid);

            return contentGrid;
        }

        private void CreateActionBar(Grid layout)
        {
            var row = new RowDefinition();
            row.Height = new GridLength(DisplayConstants.Dimensions.Forms.RdpSection.ActionBarHeight);

            layout.RowDefinitions.Add(row);

            var panel = new DockPanel();
            panel.Background = EasyColour.BrushFromHex(DisplayConstants.Colours.Forms.RdpSection.ActionBarBackgroundGrey);
            var thick = new Thickness(DisplayConstants.Dimensions.Forms.RdpSection.PaddingLeft, 0, DisplayConstants.Dimensions.Forms.RdpSection.PaddingRight, 0);
            panel.Margin = thick;

            Grid.SetRow(panel, 2);

            var border = BorderFactory.BevelFull(DisplayConstants.Colours.Borders.RdpSection.ActionBarBorder);
            border.Margin = thick;
            Grid.SetRow(border, 2);

            layout.Children.Add(panel);
            layout.Children.Add(border);
        }

        private void CreateSuperGrid(Grid layout)
        {
            var grid = new SuperGridFabricator().Fabricate();
            var thick = new Thickness(DisplayConstants.Dimensions.Forms.RdpSection.PaddingLeft, 0, DisplayConstants.Dimensions.Forms.RdpSection.PaddingRight, 0);
            grid.Margin = thick;

            Grid.SetRow(grid, 3);
            Grid.SetColumn(grid, 0);

            layout.Children.Add(grid);
        }
    }
}
