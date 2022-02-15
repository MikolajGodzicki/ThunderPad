
namespace ThunderPad {
    partial class AddThemeDialog {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.ThemeName = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.TextBackColor = new System.Windows.Forms.Button();
            this.ColorBackTextPreview = new System.Windows.Forms.Label();
            this.Create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ThemeName
            // 
            this.ThemeName.Location = new System.Drawing.Point(100, 12);
            this.ThemeName.Name = "ThemeName";
            this.ThemeName.Size = new System.Drawing.Size(263, 20);
            this.ThemeName.TabIndex = 0;
            this.ThemeName.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nazwa motywu:";
            // 
            // TextBackColor
            // 
            this.TextBackColor.Location = new System.Drawing.Point(15, 56);
            this.TextBackColor.Name = "TextBackColor";
            this.TextBackColor.Size = new System.Drawing.Size(144, 23);
            this.TextBackColor.TabIndex = 2;
            this.TextBackColor.Text = "Kolor Tła Tekstu";
            this.TextBackColor.UseVisualStyleBackColor = true;
            this.TextBackColor.Click += new System.EventHandler(this.TextBackColor_Click);
            // 
            // ColorBackTextPreview
            // 
            this.ColorBackTextPreview.AutoSize = true;
            this.ColorBackTextPreview.BackColor = System.Drawing.Color.White;
            this.ColorBackTextPreview.ForeColor = System.Drawing.Color.White;
            this.ColorBackTextPreview.Location = new System.Drawing.Point(165, 61);
            this.ColorBackTextPreview.Name = "ColorBackTextPreview";
            this.ColorBackTextPreview.Size = new System.Drawing.Size(14, 13);
            this.ColorBackTextPreview.TabIndex = 3;
            this.ColorBackTextPreview.Text = "C";
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(354, 334);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(98, 23);
            this.Create.TabIndex = 4;
            this.Create.Text = "Utwórz";
            this.Create.UseVisualStyleBackColor = true;
            // 
            // AddThemeDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 369);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.ColorBackTextPreview);
            this.Controls.Add(this.TextBackColor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ThemeName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddThemeDialog";
            this.Text = "Dodaj Motyw";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox ThemeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button TextBackColor;
        private System.Windows.Forms.Label ColorBackTextPreview;
        private System.Windows.Forms.Button Create;
    }
}