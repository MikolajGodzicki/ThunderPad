using System;
using System.Windows.Forms;
using ThunderPad.Utils;

namespace ThunderPad {
    public partial class FindDialog : Form {
        RichTextBox MainTextBox;

        public FindDialog(RichTextBox MainTextBox_) {
            InitializeComponent();
            MainTextBox = MainTextBox_;
            UpdateText();
        }

        private void FindButtonClick(object sender, EventArgs e) {
            var FoundedIndex = MainTextBox.Find(TextToFind.Text);
            if (FoundedIndex >= 0) {
                MainTextBox.SelectionStart = FoundedIndex;
            } else {
                MessageBox.Show(Const.CannotFind, Const.Information, MessageBoxButtons.OK);
            }

            if (TextToReplace.Text != "") {
                MainTextBox.Text = MainTextBox.Text.Replace(TextToFind.Text, TextToReplace.Text);
            }

            Hide();
        }

        private void ReplaceCheckBoxChecked(object sender, EventArgs e) {
            UpdateText();
        }

        private void UpdateText() {
            if (ReplaceCheckBox.Checked) {
                TextToReplace.Visible = true;
                Replace.Visible = true;
                FindButton.Text = Const.FindAndReplaceText;
            } else {
                TextToReplace.Visible = false;
                Replace.Visible = false;
                FindButton.Text = Const.FindText;
            }
        }

        public void LoadTheme(ThemeManager.Themes theme) {
            ReplaceCheckBox.ForeColor = Const.themeDictionary[theme][1];
            TextToFind.BackColor = Const.themeDictionary[theme][0];
            TextToFind.ForeColor = Const.themeDictionary[theme][1];
            Find.BackColor = Const.themeDictionary[theme][2];
            Find.ForeColor = Const.themeDictionary[theme][1];
            Replace.BackColor = Const.themeDictionary[theme][2];
            Replace.ForeColor = Const.themeDictionary[theme][1];
            TextToReplace.BackColor = Const.themeDictionary[theme][0];
            TextToReplace.ForeColor = Const.themeDictionary[theme][1];
            FindButton.BackColor = Const.themeDictionary[theme][9];
            FindButton.ForeColor = Const.themeDictionary[theme][3];
            BackColor = Const.themeDictionary[theme][2];
        }
    }
}
