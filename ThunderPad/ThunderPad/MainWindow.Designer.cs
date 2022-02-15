
namespace ThunderPad {
    partial class TitleText {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TitleText));
            this.MenuItems = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewWindowItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator_0 = new System.Windows.Forms.ToolStripSeparator();
            this.PrintItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator_1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UndoItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RedoItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator_2 = new System.Windows.Forms.ToolStripSeparator();
            this.CopyItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CutItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FindItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DuplicateItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Separator_3 = new System.Windows.Forms.ToolStripSeparator();
            this.SelectAllItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DateItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WrapItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusBarItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ZoomMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ZoomInItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ZoomOutItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResetZoomItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.RefreshTheme = new System.Windows.Forms.ToolStripMenuItem();
            this.ThemeChoose = new System.Windows.Forms.ToolStripComboBox();
            this.AddThemeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.FontDialog = new System.Windows.Forms.FontDialog();
            this.PrintDialog = new System.Windows.Forms.PrintDialog();
            this.PrintDocument = new System.Drawing.Printing.PrintDocument();
            this.ColorDIalog = new System.Windows.Forms.ColorDialog();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.LineText = new System.Windows.Forms.ToolStripStatusLabel();
            this.ColumnText = new System.Windows.Forms.ToolStripStatusLabel();
            this.CharCountText = new System.Windows.Forms.ToolStripStatusLabel();
            this.WordCountText = new System.Windows.Forms.ToolStripStatusLabel();
            this.ZoomStatusStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.CurrentThemeStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.LineNumber = new System.Windows.Forms.RichTextBox();
            this.MainTextBox = new System.Windows.Forms.RichTextBox();
            this.MenuItems.SuspendLayout();
            this.StatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.MenuItems.BackColor = System.Drawing.SystemColors.Control;
            this.MenuItems.GripMargin = new System.Windows.Forms.Padding(0);
            this.MenuItems.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.EditMenuItem,
            this.FormatMenuItem,
            this.ViewMenuItem});
            this.MenuItems.Location = new System.Drawing.Point(0, 0);
            this.MenuItems.Name = "Menu";
            this.MenuItems.Size = new System.Drawing.Size(771, 24);
            this.MenuItems.TabIndex = 0;
            this.MenuItems.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewItem,
            this.NewWindowItem,
            this.SaveItem,
            this.OpenItem,
            this.Separator_0,
            this.PrintItem,
            this.Separator_1,
            this.ExitItem});
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(38, 20);
            this.FileMenuItem.Text = "Plik";
            // 
            // NewItem
            // 
            this.NewItem.Name = "NewItem";
            this.NewItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.NewItem.Size = new System.Drawing.Size(210, 22);
            this.NewItem.Text = "Nowy";
            this.NewItem.Click += new System.EventHandler(this.NewClick);
            // 
            // NewWindowItem
            // 
            this.NewWindowItem.Name = "NewWindowItem";
            this.NewWindowItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.NewWindowItem.Size = new System.Drawing.Size(210, 22);
            this.NewWindowItem.Text = "Nowe okno";
            this.NewWindowItem.Click += new System.EventHandler(this.NewWindowClick);
            // 
            // SaveItem
            // 
            this.SaveItem.Name = "SaveItem";
            this.SaveItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveItem.Size = new System.Drawing.Size(210, 22);
            this.SaveItem.Text = "Zapisz";
            this.SaveItem.Click += new System.EventHandler(this.SaveClick);
            // 
            // OpenItem
            // 
            this.OpenItem.Name = "OpenItem";
            this.OpenItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenItem.Size = new System.Drawing.Size(210, 22);
            this.OpenItem.Text = "Otwórz...";
            this.OpenItem.Click += new System.EventHandler(this.OpenClick);
            // 
            // Separator_0
            // 
            this.Separator_0.Name = "Separator_0";
            this.Separator_0.Size = new System.Drawing.Size(207, 6);
            // 
            // PrintItem
            // 
            this.PrintItem.Name = "PrintItem";
            this.PrintItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.PrintItem.Size = new System.Drawing.Size(210, 22);
            this.PrintItem.Text = "Drukuj";
            this.PrintItem.Click += new System.EventHandler(this.PrintClick);
            // 
            // Separator_1
            // 
            this.Separator_1.Name = "Separator_1";
            this.Separator_1.Size = new System.Drawing.Size(207, 6);
            // 
            // ExitItem
            // 
            this.ExitItem.Name = "ExitItem";
            this.ExitItem.Size = new System.Drawing.Size(210, 22);
            this.ExitItem.Text = "Zamknij";
            this.ExitItem.Click += new System.EventHandler(this.ExitClick);
            // 
            // EditMenuItem
            // 
            this.EditMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UndoItem,
            this.RedoItem,
            this.Separator_2,
            this.CopyItem,
            this.PasteItem,
            this.CutItem,
            this.FindItem,
            this.DuplicateItem,
            this.Separator_3,
            this.SelectAllItem,
            this.DateItem});
            this.EditMenuItem.Name = "EditMenuItem";
            this.EditMenuItem.Size = new System.Drawing.Size(53, 20);
            this.EditMenuItem.Text = "Edycja";
            // 
            // UndoItem
            // 
            this.UndoItem.Name = "UndoItem";
            this.UndoItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.UndoItem.Size = new System.Drawing.Size(223, 22);
            this.UndoItem.Text = "Cofnij";
            this.UndoItem.Click += new System.EventHandler(this.UndoClick);
            // 
            // RedoItem
            // 
            this.RedoItem.Name = "RedoItem";
            this.RedoItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.RedoItem.Size = new System.Drawing.Size(223, 22);
            this.RedoItem.Text = "Ponów";
            this.RedoItem.Click += new System.EventHandler(this.RedoClick);
            // 
            // Separator_2
            // 
            this.Separator_2.Name = "Separator_2";
            this.Separator_2.Size = new System.Drawing.Size(220, 6);
            // 
            // CopyItem
            // 
            this.CopyItem.Name = "CopyItem";
            this.CopyItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.CopyItem.Size = new System.Drawing.Size(223, 22);
            this.CopyItem.Text = "Kopiuj";
            this.CopyItem.Click += new System.EventHandler(this.CopyClick);
            // 
            // PasteItem
            // 
            this.PasteItem.Name = "PasteItem";
            this.PasteItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.PasteItem.Size = new System.Drawing.Size(223, 22);
            this.PasteItem.Text = "Wklej";
            this.PasteItem.Click += new System.EventHandler(this.PasteClick);
            // 
            // CutItem
            // 
            this.CutItem.Name = "CutItem";
            this.CutItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.CutItem.Size = new System.Drawing.Size(223, 22);
            this.CutItem.Text = "Wytnij";
            this.CutItem.Click += new System.EventHandler(this.CutClick);
            // 
            // FindItem
            // 
            this.FindItem.Name = "FindItem";
            this.FindItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.FindItem.Size = new System.Drawing.Size(223, 22);
            this.FindItem.Text = "Znajdź";
            this.FindItem.Click += new System.EventHandler(this.FindItem_Click);
            // 
            // DuplicateItem
            // 
            this.DuplicateItem.Name = "DuplicateItem";
            this.DuplicateItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.DuplicateItem.Size = new System.Drawing.Size(223, 22);
            this.DuplicateItem.Text = "Duplikuj";
            this.DuplicateItem.Click += new System.EventHandler(this.DuplicateClick);
            // 
            // Separator_3
            // 
            this.Separator_3.Name = "Separator_3";
            this.Separator_3.Size = new System.Drawing.Size(220, 6);
            // 
            // SelectAllItem
            // 
            this.SelectAllItem.Name = "SelectAllItem";
            this.SelectAllItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.SelectAllItem.Size = new System.Drawing.Size(223, 22);
            this.SelectAllItem.Text = "Zaznacz caly tekst";
            this.SelectAllItem.Click += new System.EventHandler(this.SelectAllClick);
            // 
            // DateItem
            // 
            this.DateItem.Name = "DateItem";
            this.DateItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.DateItem.Size = new System.Drawing.Size(223, 22);
            this.DateItem.Text = "Godzina i data";
            this.DateItem.Click += new System.EventHandler(this.DateClick);
            // 
            // FormatMenuItem
            // 
            this.FormatMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FontItem,
            this.ColorItem,
            this.WrapItem});
            this.FormatMenuItem.Name = "FormatMenuItem";
            this.FormatMenuItem.Size = new System.Drawing.Size(57, 20);
            this.FormatMenuItem.Text = "Format";
            // 
            // FontItem
            // 
            this.FontItem.Name = "FontItem";
            this.FontItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.FontItem.Size = new System.Drawing.Size(205, 22);
            this.FontItem.Text = "Czcionka";
            this.FontItem.Click += new System.EventHandler(this.FontClick);
            // 
            // ColorItem
            // 
            this.ColorItem.Name = "ColorItem";
            this.ColorItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.ColorItem.Size = new System.Drawing.Size(205, 22);
            this.ColorItem.Text = "Kolor";
            this.ColorItem.Click += new System.EventHandler(this.ColorClick);
            // 
            // WrapItem
            // 
            this.WrapItem.CheckOnClick = true;
            this.WrapItem.Name = "WrapItem";
            this.WrapItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.WrapItem.Size = new System.Drawing.Size(205, 22);
            this.WrapItem.Text = "Zawijanie wierszy";
            this.WrapItem.Click += new System.EventHandler(this.WrapClick);
            // 
            // ViewMenuItem
            // 
            this.ViewMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusBarItem,
            this.ZoomMenuItem,
            this.toolStripSeparator1,
            this.RefreshTheme,
            this.ThemeChoose,
            this.AddThemeMenuItem});
            this.ViewMenuItem.Name = "ViewMenuItem";
            this.ViewMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ViewMenuItem.Text = "Widok";
            // 
            // StatusBarItem
            // 
            this.StatusBarItem.Checked = true;
            this.StatusBarItem.CheckOnClick = true;
            this.StatusBarItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.StatusBarItem.Name = "StatusBarItem";
            this.StatusBarItem.Size = new System.Drawing.Size(181, 22);
            this.StatusBarItem.Text = "Pasek Stanu";
            this.StatusBarItem.Click += new System.EventHandler(this.StatusBarClick);
            // 
            // ZoomMenuItem
            // 
            this.ZoomMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ZoomInItem,
            this.ZoomOutItem,
            this.ResetZoomItem});
            this.ZoomMenuItem.Name = "ZoomMenuItem";
            this.ZoomMenuItem.Size = new System.Drawing.Size(181, 22);
            this.ZoomMenuItem.Text = "Skalowanie";
            // 
            // ZoomInItem
            // 
            this.ZoomInItem.Name = "ZoomInItem";
            this.ZoomInItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Up)));
            this.ZoomInItem.Size = new System.Drawing.Size(193, 22);
            this.ZoomInItem.Text = "Powiększ";
            this.ZoomInItem.Click += new System.EventHandler(this.ZoomInClick);
            // 
            // ZoomOutItem
            // 
            this.ZoomOutItem.Name = "ZoomOutItem";
            this.ZoomOutItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Down)));
            this.ZoomOutItem.Size = new System.Drawing.Size(193, 22);
            this.ZoomOutItem.Text = "Pomniejsz";
            this.ZoomOutItem.Click += new System.EventHandler(this.ZoomOutClick);
            // 
            // ResetZoomItem
            // 
            this.ResetZoomItem.Name = "ResetZoomItem";
            this.ResetZoomItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.ResetZoomItem.Size = new System.Drawing.Size(193, 22);
            this.ResetZoomItem.Text = "Resetuj skale";
            this.ResetZoomItem.Click += new System.EventHandler(this.ResetZoomClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // RefreshTheme
            // 
            this.RefreshTheme.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.RefreshTheme.Name = "RefreshTheme";
            this.RefreshTheme.Size = new System.Drawing.Size(181, 22);
            this.RefreshTheme.Text = "Motyw: ";
            // 
            // ThemeChoose
            // 
            this.ThemeChoose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ThemeChoose.BackColor = System.Drawing.SystemColors.Window;
            this.ThemeChoose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ThemeChoose.Name = "ThemeChoose";
            this.ThemeChoose.Size = new System.Drawing.Size(121, 23);
            this.ThemeChoose.SelectedIndexChanged += new System.EventHandler(this.ThemeChooseSelectedItem);
            // 
            // AddThemeMenuItem
            // 
            this.AddThemeMenuItem.Name = "AddThemeMenuItem";
            this.AddThemeMenuItem.Size = new System.Drawing.Size(181, 22);
            this.AddThemeMenuItem.Text = "Dodaj motyw...";
            this.AddThemeMenuItem.Click += new System.EventHandler(this.AddThemeClick);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "OpenFileDialog";
            // 
            // PrintDialog
            // 
            this.PrintDialog.UseEXDialog = true;
            // 
            // PrintDocument
            // 
            this.PrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.CreatePrintGraphics);
            // 
            // StatusBar
            // 
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LineText,
            this.ColumnText,
            this.CharCountText,
            this.WordCountText,
            this.ZoomStatusStrip,
            this.CurrentThemeStrip});
            this.StatusBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.StatusBar.Location = new System.Drawing.Point(0, 413);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StatusBar.Size = new System.Drawing.Size(771, 24);
            this.StatusBar.TabIndex = 2;
            this.StatusBar.Text = "StatusBar";
            // 
            // LineText
            // 
            this.LineText.Name = "LineText";
            this.LineText.Size = new System.Drawing.Size(35, 19);
            this.LineText.Text = "Lin: 1";
            // 
            // ColumnText
            // 
            this.ColumnText.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.ColumnText.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.ColumnText.Name = "ColumnText";
            this.ColumnText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ColumnText.Size = new System.Drawing.Size(40, 19);
            this.ColumnText.Text = "Kol: 0";
            this.ColumnText.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // CharCountText
            // 
            this.CharCountText.Name = "CharCountText";
            this.CharCountText.Size = new System.Drawing.Size(51, 19);
            this.CharCountText.Text = "Znaki: 0,";
            // 
            // WordCountText
            // 
            this.WordCountText.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.WordCountText.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.WordCountText.Name = "WordCountText";
            this.WordCountText.Size = new System.Drawing.Size(54, 19);
            this.WordCountText.Text = "Słowa: 0";
            // 
            // ZoomStatusStrip
            // 
            this.ZoomStatusStrip.ActiveLinkColor = System.Drawing.Color.Red;
            this.ZoomStatusStrip.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.ZoomStatusStrip.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.ZoomStatusStrip.Name = "ZoomStatusStrip";
            this.ZoomStatusStrip.Size = new System.Drawing.Size(43, 19);
            this.ZoomStatusStrip.Text = "Zoom";
            // 
            // CurrentThemeStrip
            // 
            this.CurrentThemeStrip.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.CurrentThemeStrip.Name = "CurrentThemeStrip";
            this.CurrentThemeStrip.Size = new System.Drawing.Size(83, 19);
            this.CurrentThemeStrip.Text = "CurrentTheme";
            // 
            // LineNumber
            // 
            this.LineNumber.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.LineNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LineNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LineNumber.Dock = System.Windows.Forms.DockStyle.Left;
            this.LineNumber.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LineNumber.HideSelection = false;
            this.LineNumber.Location = new System.Drawing.Point(0, 24);
            this.LineNumber.Name = "LineNumber";
            this.LineNumber.ReadOnly = true;
            this.LineNumber.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.LineNumber.ShortcutsEnabled = false;
            this.LineNumber.Size = new System.Drawing.Size(40, 389);
            this.LineNumber.TabIndex = 4;
            this.LineNumber.Text = "";
            this.LineNumber.WordWrap = false;
            // 
            // MainTextBox
            // 
            this.MainTextBox.AcceptsTab = true;
            this.MainTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MainTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MainTextBox.Location = new System.Drawing.Point(40, 24);
            this.MainTextBox.Name = "MainTextBox";
            this.MainTextBox.Size = new System.Drawing.Size(731, 389);
            this.MainTextBox.TabIndex = 5;
            this.MainTextBox.Text = "";
            this.MainTextBox.WordWrap = false;
            this.MainTextBox.VScroll += new System.EventHandler(this.MainTextBoxScroll);
            this.MainTextBox.FontChanged += new System.EventHandler(this.MainTextFontChanged);
            this.MainTextBox.TextChanged += new System.EventHandler(this.UpdateMainTextBox);
            this.MainTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UpdateMainTextBox);
            this.MainTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.UpdateMainTextBox);
            this.MainTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpdateMainTextBox);
            this.MainTextBox.Resize += new System.EventHandler(this.MainTextBoxResize);
            // 
            // TitleText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 437);
            this.Controls.Add(this.MainTextBox);
            this.Controls.Add(this.LineNumber);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.MenuItems);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuItems;
            this.Name = "TitleText";
            this.Text = "Thunder Pad";
            this.MenuItems.ResumeLayout(false);
            this.MenuItems.PerformLayout();
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuItems;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewItem;
        private System.Windows.Forms.ToolStripMenuItem SaveItem;
        private System.Windows.Forms.ToolStripMenuItem OpenItem;
        private System.Windows.Forms.ToolStripMenuItem EditMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FormatMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyItem;
        private System.Windows.Forms.ToolStripMenuItem PasteItem;
        private System.Windows.Forms.ToolStripMenuItem FontItem;
        private System.Windows.Forms.ToolStripMenuItem ExitItem;
        private System.Windows.Forms.ToolStripMenuItem SelectAllItem;
        private System.Windows.Forms.ToolStripMenuItem CutItem;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.FontDialog FontDialog;
        private System.Windows.Forms.ToolStripSeparator Separator_3;
        private System.Windows.Forms.ToolStripMenuItem DateItem;
        private System.Windows.Forms.ToolStripMenuItem ColorItem;
        private System.Windows.Forms.ToolStripMenuItem WrapItem;
        private System.Windows.Forms.ToolStripSeparator Separator_0;
        private System.Windows.Forms.ToolStripMenuItem PrintItem;
        private System.Windows.Forms.ToolStripSeparator Separator_1;
        private System.Windows.Forms.PrintDialog PrintDialog;
        private System.Drawing.Printing.PrintDocument PrintDocument;
        private System.Windows.Forms.ColorDialog ColorDIalog;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.ToolStripStatusLabel LineText;
        private System.Windows.Forms.ToolStripStatusLabel ColumnText;
        private System.Windows.Forms.ToolStripMenuItem NewWindowItem;
        private System.Windows.Forms.ToolStripMenuItem DuplicateItem;
        private System.Windows.Forms.ToolStripMenuItem UndoItem;
        private System.Windows.Forms.ToolStripSeparator Separator_2;
        private System.Windows.Forms.ToolStripMenuItem RedoItem;
        private System.Windows.Forms.ToolStripMenuItem ViewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StatusBarItem;
        private System.Windows.Forms.ToolStripMenuItem ZoomMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ZoomInItem;
        private System.Windows.Forms.ToolStripMenuItem ZoomOutItem;
        private System.Windows.Forms.ToolStripMenuItem ResetZoomItem;
        private System.Windows.Forms.ToolStripStatusLabel CurrentThemeStrip;
        private System.Windows.Forms.ToolStripStatusLabel ZoomStatusStrip;
        private System.Windows.Forms.ToolStripMenuItem FindItem;
        private System.Windows.Forms.RichTextBox LineNumber;
        private System.Windows.Forms.RichTextBox MainTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem RefreshTheme;
        private System.Windows.Forms.ToolStripComboBox ThemeChoose;
        private System.Windows.Forms.ToolStripStatusLabel WordCountText;
        private System.Windows.Forms.ToolStripStatusLabel CharCountText;
        private System.Windows.Forms.ToolStripMenuItem AddThemeMenuItem;
    }
}

