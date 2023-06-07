namespace GUI.OptionsUserControls
{
    partial class LanguageOptions
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LanguageSelect = new ComboBox();
            LanguageSelectLabel = new Label();
            SuspendLayout();
            // 
            // LanguageSelect
            // 
            LanguageSelect.FormattingEnabled = true;
            LanguageSelect.Location = new Point(122, 30);
            LanguageSelect.Name = "LanguageSelect";
            LanguageSelect.Size = new Size(151, 28);
            LanguageSelect.TabIndex = 0;
            // 
            // LanguageSelectLabel
            // 
            LanguageSelectLabel.AutoSize = true;
            LanguageSelectLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LanguageSelectLabel.Location = new Point(27, 31);
            LanguageSelectLabel.Name = "LanguageSelectLabel";
            LanguageSelectLabel.Size = new Size(89, 23);
            LanguageSelectLabel.TabIndex = 1;
            LanguageSelectLabel.Text = "Language:";
            // 
            // LanguageOptions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(LanguageSelectLabel);
            Controls.Add(LanguageSelect);
            MaximumSize = new Size(517, 426);
            MinimumSize = new Size(517, 426);
            Name = "LanguageOptions";
            Size = new Size(517, 426);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox LanguageSelect;
        private Label LanguageSelectLabel;
    }
}
