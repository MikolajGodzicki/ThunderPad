using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThunderPad {
    public partial class AddThemeDialog : Form {
        public AddThemeDialog() {
            InitializeComponent();
        }

        private void TextBackColor_Click(object sender, EventArgs e) {
            if (colorDialog1.ShowDialog() == DialogResult.OK) {
                ColorBackTextPreview.BackColor = colorDialog1.Color;
                ColorBackTextPreview.ForeColor = colorDialog1.Color;
            }
        }
    }
}
