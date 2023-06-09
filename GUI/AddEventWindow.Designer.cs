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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEventWindow));
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
            resources.ApplyResources(EventNameLabel, "EventNameLabel");
            EventNameLabel.Name = "EventNameLabel";
            // 
            // EventNameInput
            // 
            resources.ApplyResources(EventNameInput, "EventNameInput");
            EventNameInput.Name = "EventNameInput";
            // 
            // EventDescritpionLabel
            // 
            resources.ApplyResources(EventDescritpionLabel, "EventDescritpionLabel");
            EventDescritpionLabel.Name = "EventDescritpionLabel";
            // 
            // EventDescriptionInput
            // 
            resources.ApplyResources(EventDescriptionInput, "EventDescriptionInput");
            EventDescriptionInput.Name = "EventDescriptionInput";
            // 
            // AddButton
            // 
            resources.ApplyResources(AddButton, "AddButton");
            AddButton.Name = "AddButton";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // StartTimePicker
            // 
            StartTimePicker.Format = DateTimePickerFormat.Time;
            resources.ApplyResources(StartTimePicker, "StartTimePicker");
            StartTimePicker.Name = "StartTimePicker";
            StartTimePicker.ShowUpDown = true;
            // 
            // TimeLabel
            // 
            resources.ApplyResources(TimeLabel, "TimeLabel");
            TimeLabel.Name = "TimeLabel";
            // 
            // EndTimePicker
            // 
            EndTimePicker.Format = DateTimePickerFormat.Time;
            resources.ApplyResources(EndTimePicker, "EndTimePicker");
            EndTimePicker.Name = "EndTimePicker";
            EndTimePicker.ShowUpDown = true;
            // 
            // StartDatePicker
            // 
            StartDatePicker.Format = DateTimePickerFormat.Short;
            resources.ApplyResources(StartDatePicker, "StartDatePicker");
            StartDatePicker.Name = "StartDatePicker";
            // 
            // EndDatePicker
            // 
            EndDatePicker.Format = DateTimePickerFormat.Short;
            resources.ApplyResources(EndDatePicker, "EndDatePicker");
            EndDatePicker.Name = "EndDatePicker";
            // 
            // TimeToLabel
            // 
            resources.ApplyResources(TimeToLabel, "TimeToLabel");
            TimeToLabel.Name = "TimeToLabel";
            // 
            // AddEventWindow
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
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