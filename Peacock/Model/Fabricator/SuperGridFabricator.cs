
namespace Peacock.Model.Fabricator
{
    using Peacock.Model.Constants;
    using Peacock.Model.Fabricator.Templates;
    using Peacock.Model.Utility;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Media;

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
            CreateRows(superGrid);
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



                var label = Labels.SuperGridTitle();
                EasyLayout.SetPosition(superGrid, label, 0, i);

                var split = new GridSplitter();
                split.HorizontalAlignment = HorizontalAlignment.Right;
                split.ResizeDirection = GridResizeDirection.Columns;
                split.Background = new SolidColorBrush(Colors.Transparent);
                split.Width = 5;

                EasyLayout.SetPosition(superGrid, split, 0, i);
            }


        }

        private void CreateRows(Grid superGrid)
        {
            for (int i = 1; i <= 25; i++)
            {
                var rowDef = new RowDefinition();
                rowDef.Height = new GridLength(DisplayConstants.Dimensions.Forms.SuperGrid.RowHeight);
                superGrid.RowDefinitions.Add(rowDef);

                for (int j = 0; j <= 6; j++)
                {
                    var dp = new DockPanel();

                    if (i <= 20)
                    {
                        if (i % 2 != 0)
                        {
                            dp.Background = EasyColour.BrushFromHex(SuperGridColours.EvenRowGrey);
                        }
                        else
                        {
                            dp.Background = EasyColour.BrushFromHex(SuperGridColours.OddRowGrey);
                        }
                    }

                    var border = BorderFactory.BevelTop(SuperGridColours.RowBorder);
                    Grid.SetColumn(dp, j);
                    Grid.SetRow(dp, i);

                    Grid.SetColumn(border, j);
                    Grid.SetRow(border, i);

                    superGrid.Children.Add(dp);
                    superGrid.Children.Add(border);

                    if (j != 6 && i <= 20)
                    {
                        var borderRight = BorderFactory.BevelRight(SuperGridColours.RowBorder);
                        Grid.SetColumn(borderRight, j);
                        Grid.SetRow(borderRight, i);

                        superGrid.Children.Add(borderRight);
                    }
                }
            }
        }
    }
}
