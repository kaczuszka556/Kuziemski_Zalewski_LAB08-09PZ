namespace GUI
{
    partial class EventDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventDetails));
            EventName = new Label();
            EventTime = new Label();
            EventDesciption = new Label();
            EditEventButton = new Button();
            DeleteEventButton = new Button();
            SuspendLayout();
            // 
            // EventName
            // 
            resources.ApplyResources(EventName, "EventName");
            EventName.Name = "EventName";
            // 
            // EventTime
            // 
            resources.ApplyResources(EventTime, "EventTime");
            EventTime.Name = "EventTime";
            // 
            // EventDesciption
            // 
            resources.ApplyResources(EventDesciption, "EventDesciption");
            EventDesciption.Name = "EventDesciption";
            // 
            // EditEventButton
            // 
            resources.ApplyResources(EditEventButton, "EditEventButton");
            EditEventButton.Name = "EditEventButton";
            EditEventButton.UseVisualStyleBackColor = true;
            EditEventButton.Click += EditEventButton_Click;
            // 
            // DeleteEventButton
            // 
            resources.ApplyResources(DeleteEventButton, "DeleteEventButton");
            DeleteEventButton.Name = "DeleteEventButton";
            DeleteEventButton.UseVisualStyleBackColor = true;
            DeleteEventButton.Click += DeleteEventButton_Click;
            // 
            // EventDetails
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DeleteEventButton);
            Controls.Add(EditEventButton);
            Controls.Add(EventDesciption);
            Controls.Add(EventTime);
            Controls.Add(EventName);
            Name = "EventDetails";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EventName;
        private Label EventTime;
        private Label EventDesciption;
        private Button EditEventButton;
        private Button DeleteEventButton;
    }
}