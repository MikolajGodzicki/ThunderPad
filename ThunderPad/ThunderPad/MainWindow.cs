using ThunderPad.Utils;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static ThunderPad.Utils.ThemeManager;

namespace ThunderPad {
    public partial class TitleText : Form {
        int WordCount = 0;
        int CharCount = 0;

        public TitleText() {
            InitializeComponent();
            InitializeNotepad();
        }

        #region Initialize
        int line;
        int column;
        Themes CurrentTheme;

        void InitializeNotepad() {
            InitializeAlignment();
            InitalizeSaveFilters();
            InitializeTheme();
            UpdateMainTextBox(null, new EventArgs());
        }

        void InitalizeSaveFilters() {
            SaveFileDialog.DefaultExt = ".txt";
            var filterString = "";
            foreach (var item in Const.filterList) {
                filterString += item;
            }
            SaveFileDialog.Filter = filterString;
        }

        void InitializeTheme() {
            foreach (var item in Enum.GetNames(typeof(Themes)))
                ThemeChoose.Items.Add(item);
            ThemeChoose.SelectedIndex = (int)Themes.Monokai; // Podstawowy Motyw
            UpdateCurrentThemeText();
        }

        void InitializeAlignment() {
            CurrentThemeStrip.Alignment = ToolStripItemAlignment.Right;
            ZoomStatusStrip.Alignment = ToolStripItemAlignment.Right;
        }
        #endregion

        #region Plik
        private void NewClick(object sender, EventArgs e) {
            if (MainTextBox.TextLength <= 0) {
                MainTextBox.Clear();
                return;
            }

            var dialog = MessageBox.Show(Const.AreYouSure, Const.Information, MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
                MainTextBox.Clear();
        }

        private void NewWindowClick(object sender, EventArgs e) {
            new TitleText().Show();
        }

        private void SaveClick(object sender, EventArgs e) {
            if (SaveFileDialog.ShowDialog() == DialogResult.OK) { 
                MainTextBox.SaveFile(SaveFileDialog.FileName, RichTextBoxStreamType.PlainText);
                Text = $"{Text} - Editing: {SaveFileDialog.FileName}";
            }
        }

        private void OpenClick(object sender, EventArgs e) {
            if (OpenFileDialog.ShowDialog() == DialogResult.OK) {
                MainTextBox.Text = File.ReadAllText(OpenFileDialog.FileName);
                Text = $"{Text} - Editing: {OpenFileDialog.FileName}";
            }
        }
        private void PrintClick(object sender, EventArgs e) {
            if (PrintDialog.ShowDialog() == DialogResult.OK)
                PrintDocument.Print();
        }

        private void CreatePrintGraphics(object sender, PrintPageEventArgs e) {
            e.Graphics.DrawString(MainTextBox.Text, MainTextBox.Font, new SolidBrush(MainTextBox.ForeColor), 10, 10);
        }

        private void ExitClick(object sender, EventArgs e) {
            if (MainTextBox.TextLength <= 0)
                Application.Exit();

            var dialog = MessageBox.Show(Const.AreYouSure, Const.Information, MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
                Application.Exit();
        }
        #endregion

        #region Edycja
        private void RedoClick(object sender, EventArgs e) {
            MainTextBox.Redo();
        }

        private void UndoClick(object sender, EventArgs e) {
            MainTextBox.Undo();
        }

        private void CopyClick(object sender, EventArgs e) {
            MainTextBox.Copy();
        }

        private void PasteClick(object sender, EventArgs e) {
            MainTextBox.Paste();
        }

        private void CutClick(object sender, EventArgs e) {
            MainTextBox.Cut();
        }

        private void FindItem_Click(object sender, EventArgs e) {
            FindDialog Find = new FindDialog(MainTextBox);
            Find.LoadTheme(CurrentTheme);
            Find.Show();
        }
        private void DuplicateClick(object sender, EventArgs e) {
            UpdateStatusStrip();

            line = MainTextBox.GetLineFromCharIndex(MainTextBox.SelectionStart);
            if (line < MainTextBox.Lines.Length) {
                string text = $"\n{MainTextBox.Lines[line]}";
                var selection = MainTextBox.SelectionStart;
                MainTextBox.Text = MainTextBox.Text.Insert(selection, text);
                MainTextBox.SelectionStart = selection;
            }
        }

        private void SelectAllClick(object sender, EventArgs e) {
            MainTextBox.SelectAll();
        }

        private void DateClick(object sender, EventArgs e) {
            string text = $"{DateTime.Now}";
            var selection = MainTextBox.SelectionStart;
            MainTextBox.Text = MainTextBox.Text.Insert(selection, text);
            MainTextBox.SelectionStart = selection + text.Length;
        }
        #endregion

        #region Format
        private void FontClick(object sender, EventArgs e) {
            if (FontDialog.ShowDialog() == DialogResult.OK) { 
                MainTextBox.Font = FontDialog.Font;
                LineNumber.Font = FontDialog.Font;
            }

        }
        private void ColorClick(object sender, EventArgs e) {
            if (ColorDIalog.ShowDialog() == DialogResult.OK)
                MainTextBox.ForeColor = ColorDIalog.Color;
        }

        private void WrapClick(object sender, EventArgs e) {
            if (WrapItem.Checked)
                MainTextBox.WordWrap = true;
            else
                MainTextBox.WordWrap = false;
            UpdateStatusStrip();
            UpdateLineNumber();
        }
        #endregion

        #region Widok
        private void ZoomInClick(object sender, EventArgs e) {
            if (MainTextBox.ZoomFactor < Const.ZoomMax) {
                MainTextBox.ZoomFactor += Const.ZoomIn;
                LineNumber.ZoomFactor = MainTextBox.ZoomFactor;
            }
            UpdateZoomText();
        }

        private void ZoomOutClick(object sender, EventArgs e) {
            if (MainTextBox.ZoomFactor > Const.ZoomMin) {
                MainTextBox.ZoomFactor -= Const.ZoomOut;
                LineNumber.ZoomFactor = MainTextBox.ZoomFactor;
            }
            UpdateZoomText();
        }

        private void ResetZoomClick(object sender, EventArgs e) {
            MainTextBox.ZoomFactor = Const.SizeDefault;
            LineNumber.ZoomFactor = MainTextBox.ZoomFactor;
            UpdateZoomText();
            
        }

        private void StatusBarClick(object sender, EventArgs e) {
            if (StatusBarItem.Checked)
                StatusBar.Show();
            else
                StatusBar.Hide();
            LineNumber.Location = new Point(0, Const.LineNumberPoint);
        }

        private void UpdateZoomText()
        {
            ZoomStatusStrip.Text = $@"{Const.ZoomText} {CalculateZoom(MainTextBox.ZoomFactor)}%";
        }

        private float CalculateZoom(float zoom) {
            var item = zoom * 100;
            return item;
        }
        #endregion

        #region Liczba linii, kolumn, słów
        private void UpdateMainTextBox(object sender, EventArgs e) {
            UpdateStatusStrip();
            UpdateLineNumber();
            UpdateWordCountText();
            UpdateZoomText();
        }

        private void UpdateMainTextBox(object sender, MouseEventArgs e) {
            UpdateStatusStrip();
            UpdateLineNumber();
            UpdateZoomText();
        }

        private void UpdateMainTextBox(object sender, KeyEventArgs e) {
            UpdateStatusStrip();
        }

        void UpdateStatusStrip() {
            line = MainTextBox.GetLineFromCharIndex(MainTextBox.SelectionStart);
            column = MainTextBox.SelectionStart - MainTextBox.GetFirstCharIndexFromLine(line);
            LineText.Text = $"{Const.LineText}: {line + 1},";
            ColumnText.Text = $"{Const.ColumnText}: {column}";
        }

        //Liczba linii po lewej stronie tekstu
        private void UpdateLineNumber() {
            LineNumber.ZoomFactor = MainTextBox.ZoomFactor;
            Point pos = new Point(0, 0);
            int firstIndex = MainTextBox.GetCharIndexFromPosition(pos);
            int firstLine = MainTextBox.GetLineFromCharIndex(firstIndex);

            pos.X = ClientRectangle.Width;
            pos.Y = ClientRectangle.Height;
            int lastIndex = MainTextBox.GetCharIndexFromPosition(pos) + 1;
            int lastLine = MainTextBox.GetLineFromCharIndex(lastIndex);

            string text = "";
            for (int i = firstLine; i <= lastLine; i++) {
                text += $" {i + 1}:\n";
            }
            LineNumber.Text = text;
        }

        private void MainTextBoxScroll(object sender, EventArgs e) {
            LineNumber.Location = new Point(0, Const.LineNumberPoint);
            UpdateLineNumber();
        }

        private void MainTextBoxResize(object sender, EventArgs e) {
            MainTextBoxScroll(null, null);
        }

        private void MainTextFontChanged(object sender, EventArgs e) {
            UpdateLineNumber();
            MainTextBoxScroll(null, null);
        }

        private void UpdateWordCountText() {
            WordCount = MainTextBox.Text.Split(' ').Length + MainTextBox.Text.Split('\n').Length - 1;
            if (MainTextBox.Text.Length == 0)
                WordCount = 0;
            CharCount = MainTextBox.Text.Length;
            WordCountText.Text = $"{Const.WordCountText}: {WordCount}";
            CharCountText.Text = $"{Const.CharCountText}: {CharCount},";
        }
        #endregion

        #region Theme
        string currentTheme;

        void LoadTheme(Themes theme) {
            ChangeColor(Const.themeDictionary[theme]);
            currentTheme = Enum.GetName(typeof(Themes), theme);
            CurrentTheme = theme;
            MenuItems.Renderer = new ToolStripProfessionalRenderer(new MenuStripColor(theme));
        }

        void ChangeColor(Color[] colors) {
            MenuItems.BackgroundImage = null;
            StatusBar.BackgroundImage = null;

            MainTextBox.BackColor = colors[0];
            MainTextBox.ForeColor = colors[1];
            MenuItems.BackColor = colors[2];
            MenuItems.ForeColor = colors[3];
            StatusBar.BackColor = colors[4];
            StatusBar.ForeColor = colors[5];
            LineNumber.BackColor = colors[6];
            LineNumber.ForeColor = colors[7];
            ThemeChoose.BackColor = colors[2];
            ThemeChoose.ForeColor = colors[3];

            foreach (ToolStripMenuItem item in MenuItems.Items) {
                foreach (ToolStripMenuItem InsideItem in item.DropDownItems.OfType<ToolStripMenuItem>()) {
                    InsideItem.ForeColor = colors[3]; 
                    if (InsideItem == ZoomMenuItem) {
                        foreach (ToolStripItem ZoomItem in InsideItem.DropDownItems)
                            ZoomItem.ForeColor = colors[3];
                    }
                }
            }
        }

        void UpdateCurrentThemeText() {
            CurrentThemeStrip.Text = currentTheme;
        }

        private void ThemeChooseSelectedItem(object sender, EventArgs e) {
            if (ThemeChoose.SelectedIndex < 0)
                return;

            if (ThemeChoose.SelectedIndex > Const.Translation.Count)
                return;

            ViewMenuItem.HideDropDown();
            LoadTheme(Const.Translation[ThemeChoose.SelectedIndex]);
            UpdateCurrentThemeText();
        }
        private void AddThemeClick(object sender, EventArgs e) {
            AddThemeDialog ATD = new AddThemeDialog();
            ATD.Show();
        }
        #endregion
    }
}
