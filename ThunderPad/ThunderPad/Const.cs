using System.Collections.Generic;
using System.Drawing;
using static ThunderPad.Utils.ThemeManager;

namespace ThunderPad {
    class Const
    {
        public const string LineText = "Lin";
        public const string ColumnText = "Kol";
        public const string WordCountText = "Słowa";
        public const string CharCountText = "Znaki";
        public const string AreYouSure = "Jesteś pewny?";
        public const string Information = "Informacja!";
        public const string ZoomText = "Zoom: ";

        public const string FindText = "Znajdź";
        public const string FindAndReplaceText = "Znajdź i zamień";

        public const string CannotFind = "Nie znaleziono tekstu.";

        public const float SizeDefault = 1f;

        public const float ZoomIn = 0.5f;
        public const float ZoomOut = 0.5f;
        public const float ZoomMax = 63f;
        public const float ZoomMin = 0.5f;

        public const int LineNumberPoint = 24;

        public static readonly string[] filterList = {
            "Plik tekstowy|*.txt|",
            "Plik PDF|*.pdf|",
            "Plik Word|*.doc|",
            "Plik C++|*.cpp|",
            "Plik Header|*.h|",
            "Plik C|*.c|",
            "Plik C#|*.cs|",
            "Plik Python|*.py|",
            "Plik JavaScript|*.js|",
            "Plik HTML|*.html|",
            "Plik CSS|*.css|",
            "Plik RTF|*.rtf"
        };

        public static readonly Dictionary<Themes, Color[]> themeDictionary = new Dictionary<Themes, Color[]> {
                {Themes.Light, new Color[] {
                    Color.FromArgb(250, 238, 224), // TextBox BackColor
                    Color.FromArgb(72, 52, 52), // TextBox ForeColor
                    Color.FromArgb(249, 228, 200), // Menu BackColor
                    Color.FromArgb(72, 52, 52), // Menu ForeColor
                    Color.FromArgb(249, 228, 200), // StatusBar BackColor
                    Color.FromArgb(72, 52, 52), // StatusBar ForeColor
                    Color.FromArgb(249, 228, 200), // LineNumber BackColor
                    Color.FromArgb(72, 52, 52), // LineNumber ForeColor
                    Color.FromArgb(255, 238, 210), // Menu Item Selected
                    Color.FromArgb(255, 248, 230), // Menu Item Border
                    Color.FromArgb(195, 176, 145), // Find Button
                } },
                {Themes.Dark, new Color[] {
                    Color.FromArgb(30, 30, 30),
                    Color.LightGray,
                    Color.FromArgb(20, 20, 20),
                    Color.LightGray,
                    Color.FromArgb(20, 20, 20),
                    Color.LightGray,
                    Color.FromArgb(25, 25, 25),
                    Color.LightGray,
                    Color.FromArgb(10, 10, 10),
                    Color.FromArgb(0, 0, 0),
                } },
                {Themes.Monokai, new Color[] {
                    Color.FromArgb(39, 40, 34),
                    Color.LightGray,
                    Color.FromArgb(35, 36, 30),
                    Color.LightGray,
                    Color.FromArgb(35, 36, 30),
                    Color.LightGray,
                    Color.FromArgb(35, 36, 30),
                    Color.LightGray,
                    Color.FromArgb(30, 31, 25),
                    Color.FromArgb(25, 26, 20),
                } },
                {Themes.Dracula, new Color[] {
                    Color.FromArgb(68, 71, 90),
                    Color.LightGray,
                    Color.FromArgb(40, 42, 54),
                    Color.LightGray,
                    Color.FromArgb(40, 42, 54),
                    Color.LightGray,
                    Color.FromArgb(40, 42, 54),
                    Color.LightGray,
                    Color.FromArgb(35, 37, 49),
                    Color.FromArgb(25, 27, 39),
                } },
            };

        public static readonly Dictionary<int, Themes> Translation = new Dictionary<int, Themes>(){
                {0, Themes.Light },
                {1, Themes.Dark },
                {2, Themes.Monokai },
                {3, Themes.Dracula },
            };
    }
}
