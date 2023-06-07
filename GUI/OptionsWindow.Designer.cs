namespace GUI
{
    partial class OptionsWindow
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TreeNode treeNode1 = new TreeNode("temp");
            TreeNode treeNode2 = new TreeNode("General", new TreeNode[] { treeNode1 });
            TreeNode treeNode3 = new TreeNode("Language");
            TreeNode treeNode4 = new TreeNode("Localization", new TreeNode[] { treeNode3 });
            OptionsMenu = new TreeView();
            languageOptions = new OptionsUserControls.LanguageOptions();
            SuspendLayout();
            // 
            // OptionsMenu
            // 
            OptionsMenu.Location = new Point(12, 12);
            OptionsMenu.Name = "OptionsMenu";
            treeNode1.Name = "tempChild";
            treeNode1.Text = "temp";
            treeNode1.Tag = OptionType.Temp;
            treeNode2.Name = "GeneralParentNode";
            treeNode2.Text = "General";
            treeNode3.Name = "LanguageChildNode";
            treeNode3.Text = "Language";
            treeNode3.Tag = OptionType.Language;
            treeNode4.Name = "LocalizationParentNode";
            treeNode4.Text = "Localization";
            OptionsMenu.Nodes.AddRange(new TreeNode[] { treeNode2, treeNode4 });
            OptionsMenu.Size = new Size(253, 426);
            OptionsMenu.TabIndex = 0;
            OptionsMenu.AfterSelect += OptionsMenu_AfterSelect;
            // 
            // languageOptions
            // 
            languageOptions.Location = new Point(271, 12);
            languageOptions.MaximumSize = new Size(517, 426);
            languageOptions.MinimumSize = new Size(517, 426);
            languageOptions.Name = "languageOptions";
            languageOptions.Size = new Size(517, 426);
            languageOptions.TabIndex = 1;
            languageOptions.Visible = false;
            // 
            // OptionsWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(languageOptions);
            Controls.Add(OptionsMenu);
            Name = "OptionsWindow";
            Text = "Options";
            Load += OptionsWindow_Load;
            ResumeLayout(false);
        }

        #endregion

        private TreeView OptionsMenu;
        private OptionsUserControls.LanguageOptions languageOptions;
    }
}