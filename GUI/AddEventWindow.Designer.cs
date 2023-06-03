namespace GUI
{
    partial class AddEventWindow
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
            EventNameLabel = new Label();
            EventNameInput = new TextBox();
            EventDescritpionLabel = new Label();
            EventDesriptionInput = new TextBox();
            AddButton = new Button();
            SuspendLayout();
            // 
            // EventNameLabel
            // 
            EventNameLabel.AutoSize = true;
            EventNameLabel.Location = new Point(12, 9);
            EventNameLabel.Name = "EventNameLabel";
            EventNameLabel.Size = new Size(89, 20);
            EventNameLabel.TabIndex = 0;
            EventNameLabel.Text = "Event name:";
            // 
            // EventNameInput
            // 
            EventNameInput.Location = new Point(12, 32);
            EventNameInput.Name = "EventNameInput";
            EventNameInput.Size = new Size(576, 27);
            EventNameInput.TabIndex = 1;
            // 
            // EventDescritpionLabel
            // 
            EventDescritpionLabel.AutoSize = true;
            EventDescritpionLabel.Location = new Point(12, 62);
            EventDescritpionLabel.Name = "EventDescritpionLabel";
            EventDescritpionLabel.Size = new Size(126, 20);
            EventDescritpionLabel.TabIndex = 2;
            EventDescritpionLabel.Text = "Event description:";
            // 
            // EventDesriptionInput
            // 
            EventDesriptionInput.Location = new Point(12, 85);
            EventDesriptionInput.Multiline = true;
            EventDesriptionInput.Name = "EventDesriptionInput";
            EventDesriptionInput.Size = new Size(576, 182);
            EventDesriptionInput.TabIndex = 3;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(494, 331);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(94, 29);
            AddButton.TabIndex = 4;
            AddButton.Text = "Add Event";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // AddEventWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 372);
            Controls.Add(AddButton);
            Controls.Add(EventDesriptionInput);
            Controls.Add(EventDescritpionLabel);
            Controls.Add(EventNameInput);
            Controls.Add(EventNameLabel);
            Name = "AddEventWindow";
            Text = "AddEventWindow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EventNameLabel;
        private TextBox EventNameInput;
        private Label EventDescritpionLabel;
        private TextBox EventDesriptionInput;
        private Button AddButton;
    }
}