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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LanguageOptions));
            LanguageSelect = new ComboBox();
            LanguageSelectLabel = new Label();
            SuspendLayout();
            // 
            // LanguageSelect
            // 
            LanguageSelect.FormattingEnabled = true;
            resources.ApplyResources(LanguageSelect, "LanguageSelect");
            LanguageSelect.Name = "LanguageSelect";
            LanguageSelect.SelectedIndexChanged += LanguageSelect_SelectedIndexChanged;
            // 
            // LanguageSelectLabel
            // 
            resources.ApplyResources(LanguageSelectLabel, "LanguageSelectLabel");
            LanguageSelectLabel.Name = "LanguageSelectLabel";
            // 
            // LanguageOptions
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(LanguageSelectLabel);
            Controls.Add(LanguageSelect);
            Name = "LanguageOptions";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox LanguageSelect;
        private Label LanguageSelectLabel;
    }
}
