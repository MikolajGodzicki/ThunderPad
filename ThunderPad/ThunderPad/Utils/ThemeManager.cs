using System.Drawing;
using System.Windows.Forms;

namespace ThunderPad.Utils {
    public class ThemeManager {
        public enum Themes {
            Light,
            Dark,
            Monokai,
            Dracula,
        }
    }

    public class MenuStripColor : ProfessionalColorTable {
        ThemeManager.Themes theme;
        public MenuStripColor(ThemeManager.Themes theme) {
            this.theme = theme;
        }

        public override Color ToolStripDropDownBackground {
            get {
                return Const.themeDictionary[theme][0];
            }
        }

        // Lewe Kwadraty
        public override Color ImageMarginGradientBegin {
            get {
                return Const.themeDictionary[theme][2];
            }
        }

        public override Color ImageMarginGradientMiddle {
            get {
                return Const.themeDictionary[theme][2];
            }
        }

        public override Color ImageMarginGradientEnd {
            get {
                return Const.themeDictionary[theme][2];
            }
        }
        // Lewe Kwadraty

        // Obrys
        public override Color MenuBorder {
            get {
                return Const.themeDictionary[theme][8];
            }
        }

        public override Color MenuItemBorder {
            get {
                return Const.themeDictionary[theme][9];
            }
        }
        // Obrys

        public override Color MenuItemSelected {
            get {
                return Const.themeDictionary[theme][8];
            }
        }

        public override Color MenuItemSelectedGradientBegin {
            get {
                return Const.themeDictionary[theme][8];
            }
        }

        public override Color MenuItemSelectedGradientEnd { 
            get {
                return Const.themeDictionary[theme][8];
            }
        }

        public override Color MenuItemPressedGradientBegin {
            get {
                return Const.themeDictionary[theme][8];
            }
        }

        public override Color MenuItemPressedGradientEnd {
            get {
                return Const.themeDictionary[theme][8];
            }
        }
    }
}
