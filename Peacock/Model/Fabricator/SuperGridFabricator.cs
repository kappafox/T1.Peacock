
namespace Peacock.Model.Fabricator
{
    using Peacock.Model.Constants;
    using Peacock.Model.Fabricator.Templates;
    using Peacock.Model.Utility;
    using System.Windows;
    using System.Windows.Controls;

    public class SuperGridFabricator
    {
        public Grid Fabricate()
        {
            var superGrid = new Grid();
            superGrid.SnapsToDevicePixels = true;

            for (int i = 0; i <= 6; i++)
            {
                var colDef = new ColumnDefinition();
                superGrid.ColumnDefinitions.Add(colDef);
            }

            CreateTableHeader(superGrid);
            return superGrid;
        }

        private void CreateTableHeader(Grid superGrid)
        {
            var rowDef = new RowDefinition();
            rowDef.Height = new GridLength(DisplayConstants.Dimensions.Forms.SuperGrid.TableHeaderHeight);
            superGrid.RowDefinitions.Add(rowDef);

            for (int i = 0; i <= 6; i++)
            {
                var dockPanel = new DockPanel();

                var brush = EasyColour.LinearGradientBrushFromHex(DisplayConstants.Colours.GridView.HeaderRowGradientStart,
                                                                  DisplayConstants.Colours.GridView.HeaderRowGradientEnd,
                                                                  90.0);
                dockPanel.Background = brush;

                Grid.SetRow(dockPanel, 0);
                Grid.SetColumn(dockPanel, i);

                var borderTop = BorderFactory.BevelTop(SuperGridColours.HeaderRowBorderTop);
                Grid.SetRow(borderTop, 0);
                Grid.SetColumn(borderTop, i);

                var borderBot = BorderFactory.BevelBottom(SuperGridColours.HeaderRowBorderBottom);
                Grid.SetRow(borderBot, 0);
                Grid.SetColumn(borderBot, i);

                var borderRight = BorderFactory.BevelRight(SuperGridColours.HeaderRowBorderBottom);
                Grid.SetRow(borderRight, 0);
                Grid.SetColumn(borderRight, i);

                var borderLeft = BorderFactory.BevelLeft(SuperGridColours.HeaderRowBorderLeft);
                Grid.SetRow(borderLeft, 0);
                Grid.SetColumn(borderLeft, i);

                superGrid.Children.Add(dockPanel);
                superGrid.Children.Add(borderTop);
                superGrid.Children.Add(borderBot);
                superGrid.Children.Add(borderRight);
                superGrid.Children.Add(borderLeft);
            }


        }
    }
}
