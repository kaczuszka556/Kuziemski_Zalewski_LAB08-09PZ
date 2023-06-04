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
            EventDescriptionInput = new TextBox();
            AddButton = new Button();
            StartTimePicker = new DateTimePicker();
            TimeLabel = new Label();
            EndTimePicker = new DateTimePicker();
            StartDatePicker = new DateTimePicker();
            EndDatePicker = new DateTimePicker();
            TimeToLabel = new Label();
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
            EventDescritpionLabel.Location = new Point(12, 115);
            EventDescritpionLabel.Name = "EventDescritpionLabel";
            EventDescritpionLabel.Size = new Size(126, 20);
            EventDescritpionLabel.TabIndex = 2;
            EventDescritpionLabel.Text = "Event description:";
            // 
            // EventDescriptionInput
            // 
            EventDescriptionInput.Location = new Point(12, 138);
            EventDescriptionInput.Multiline = true;
            EventDescriptionInput.Name = "EventDescriptionInput";
            EventDescriptionInput.Size = new Size(576, 182);
            EventDescriptionInput.TabIndex = 3;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(494, 565);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(94, 29);
            AddButton.TabIndex = 4;
            AddButton.Text = "Add Event";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // StartTimePicker
            // 
            StartTimePicker.Format = DateTimePickerFormat.Time;
            StartTimePicker.Location = new Point(133, 85);
            StartTimePicker.Name = "StartTimePicker";
            StartTimePicker.ShowUpDown = true;
            StartTimePicker.Size = new Size(89, 27);
            StartTimePicker.TabIndex = 5;
            // 
            // TimeLabel
            // 
            TimeLabel.AutoSize = true;
            TimeLabel.Location = new Point(12, 62);
            TimeLabel.Name = "TimeLabel";
            TimeLabel.Size = new Size(125, 20);
            TimeLabel.TabIndex = 6;
            TimeLabel.Text = "Duration of event";
            // 
            // EndTimePicker
            // 
            EndTimePicker.Format = DateTimePickerFormat.Time;
            EndTimePicker.Location = new Point(378, 85);
            EndTimePicker.Name = "EndTimePicker";
            EndTimePicker.ShowUpDown = true;
            EndTimePicker.Size = new Size(89, 27);
            EndTimePicker.TabIndex = 7;
            // 
            // StartDatePicker
            // 
            StartDatePicker.Format = DateTimePickerFormat.Short;
            StartDatePicker.Location = new Point(12, 85);
            StartDatePicker.Name = "StartDatePicker";
            StartDatePicker.Size = new Size(115, 27);
            StartDatePicker.TabIndex = 8;
            // 
            // EndDatePicker
            // 
            EndDatePicker.Format = DateTimePickerFormat.Short;
            EndDatePicker.Location = new Point(257, 85);
            EndDatePicker.Name = "EndDatePicker";
            EndDatePicker.Size = new Size(115, 27);
            EndDatePicker.TabIndex = 9;
            // 
            // TimeToLabel
            // 
            TimeToLabel.AutoSize = true;
            TimeToLabel.Location = new Point(228, 90);
            TimeToLabel.Name = "TimeToLabel";
            TimeToLabel.Size = new Size(23, 20);
            TimeToLabel.TabIndex = 10;
            TimeToLabel.Text = "to";
            // 
            // AddEventWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 606);
            Controls.Add(TimeToLabel);
            Controls.Add(EndDatePicker);
            Controls.Add(StartDatePicker);
            Controls.Add(EndTimePicker);
            Controls.Add(TimeLabel);
            Controls.Add(StartTimePicker);
            Controls.Add(AddButton);
            Controls.Add(EventDescriptionInput);
            Controls.Add(EventDescritpionLabel);
            Controls.Add(EventNameInput);
            Controls.Add(EventNameLabel);
            Name = "AddEventWindow";
            Text = "Add new event";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EventNameLabel;
        private TextBox EventNameInput;
        private Label EventDescritpionLabel;
        private TextBox EventDescriptionInput;
        private Button AddButton;
        private DateTimePicker StartTimePicker;
        private Label TimeLabel;
        private DateTimePicker EndTimePicker;
        private DateTimePicker StartDatePicker;
        private DateTimePicker EndDatePicker;
        private Label TimeToLabel;
    }
}