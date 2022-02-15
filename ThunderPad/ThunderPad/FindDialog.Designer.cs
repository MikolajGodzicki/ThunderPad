
namespace ThunderPad {
    partial class FindDialog {
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
            this.FindButton = new System.Windows.Forms.Button();
            this.TextToFind = new System.Windows.Forms.RichTextBox();
            this.TextToReplace = new System.Windows.Forms.RichTextBox();
            this.Find = new System.Windows.Forms.TextBox();
            this.Replace = new System.Windows.Forms.TextBox();
            this.ReplaceCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(13, 12);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(149, 23);
            this.FindButton.TabIndex = 0;
            this.FindButton.Text = "Znajdź i Zamień";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButtonClick);
            // 
            // TextToFind
            // 
            this.TextToFind.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextToFind.Location = new System.Drawing.Point(168, 12);
            this.TextToFind.Name = "TextToFind";
            this.TextToFind.Size = new System.Drawing.Size(224, 20);
            this.TextToFind.TabIndex = 1;
            this.TextToFind.Text = "";
            // 
            // TextToReplace
            // 
            this.TextToReplace.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextToReplace.Location = new System.Drawing.Point(168, 42);
            this.TextToReplace.Name = "TextToReplace";
            this.TextToReplace.Size = new System.Drawing.Size(224, 20);
            this.TextToReplace.TabIndex = 2;
            this.TextToReplace.Text = "";
            // 
            // Find
            // 
            this.Find.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Find.Location = new System.Drawing.Point(399, 15);
            this.Find.Name = "Find";
            this.Find.ReadOnly = true;
            this.Find.Size = new System.Drawing.Size(47, 13);
            this.Find.TabIndex = 3;
            this.Find.Text = "Znajdź";
            // 
            // Replace
            // 
            this.Replace.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Replace.Location = new System.Drawing.Point(399, 46);
            this.Replace.Name = "Replace";
            this.Replace.ReadOnly = true;
            this.Replace.Size = new System.Drawing.Size(47, 13);
            this.Replace.TabIndex = 4;
            this.Replace.Text = "Zamień";
            // 
            // ReplaceCheckBox
            // 
            this.ReplaceCheckBox.AutoSize = true;
            this.ReplaceCheckBox.Location = new System.Drawing.Point(13, 49);
            this.ReplaceCheckBox.Name = "ReplaceCheckBox";
            this.ReplaceCheckBox.Size = new System.Drawing.Size(61, 17);
            this.ReplaceCheckBox.TabIndex = 5;
            this.ReplaceCheckBox.Text = "Zamień";
            this.ReplaceCheckBox.UseVisualStyleBackColor = true;
            this.ReplaceCheckBox.CheckedChanged += new System.EventHandler(this.ReplaceCheckBoxChecked);
            // 
            // FindDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(458, 78);
            this.Controls.Add(this.ReplaceCheckBox);
            this.Controls.Add(this.Replace);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.TextToReplace);
            this.Controls.Add(this.TextToFind);
            this.Controls.Add(this.FindButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FindDialog";
            this.Text = "Znajdź";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.RichTextBox TextToFind;
        private System.Windows.Forms.RichTextBox TextToReplace;
        private System.Windows.Forms.TextBox Find;
        private System.Windows.Forms.TextBox Replace;
        private System.Windows.Forms.CheckBox ReplaceCheckBox;
    }
}