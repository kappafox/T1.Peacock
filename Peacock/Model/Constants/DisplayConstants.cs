
namespace Peacock.Model.Constants
{
    public static class DisplayConstants
    {
        public static class Colours
        {
            public static class Forms
            {
                public const string StandardBackgroundGrey = "#f2f3f4";
                public const string MainActionBarBackgroundGrey = "#EBEDEE";

                public const string PanelBackgroundWhite = "#FFFFFF";

                public const string RdpActionBarGradientStart = "#F2F3F4";
                public const string RdpActionBarGradientEnd = "#ebedee";

                public const string BannerBackgroundBlack = "#34373C";

                public static class RdpSection
                {
                    public const string ActionBarBackgroundGrey = "#E4E7E9";
                }
            }

            public static class Borders
            {
                public const string BevelBorderDark = "#D6DBDD";
                public const string BevelBorderLight = "#FFFFFF";

                public static class RdpSection
                {
                    public const string ActionBarBorder = "#BBC3C6";
                }
            }

            public static class GridView
            {
                public const string HeaderRowGradientStart = "#E4E7E8";
                public const string HeaderRowGradientEnd = "#D6DBDD";
                public const string EvenRowGrey = "#d6dbdd";
                //public const string OddRowGrey = 
            }
        }



        public static class Fonts
        {

        }

        public static class Dimensions
        {
            public static class Forms
            {
                public const long WindowHeight = 920;
                public const long WindowWidth = 1024;

                public const long MainActionBarHeight = 38;
                public const long FormControlBarHeight = 44;

                public const long BannerHeight = 40;

                public const long SectionSelectionPaneWidth = 250;

                public const long SectionSelectorHeight = 63;


                public static class RdpSection
                {
                    public const long TitleBarHeight = 45;
                    public const long HeaderBarHeight = 40;
                    public const long ActionBarHeight = 38;


                    public const long PaddingLeft = 10;
                    public const long PaddingRight = 10;


                }

                public static class SuperGrid
                {
                    public const long TableHeaderHeight = 31;
                }
            }

            public static class Borders
            {
                public const long BevelBorderThickness = 1;
            }
        }
    }
}

public static class SuperGridColours
{
    public static string HeaderRowBorderTop = "#F8F9FA";
    public static string HeaderRowBorderBottom = "#BBC3C6";
    public static string HeaderRowBorderLeft = "#F7F8F9";
}
