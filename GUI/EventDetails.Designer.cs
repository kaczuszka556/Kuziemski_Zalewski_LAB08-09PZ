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
            EventName = new Label();
            EventTime = new Label();
            EventDesciption = new Label();
            EditEventButton = new Button();
            DeleteEventButton = new Button();
            SuspendLayout();
            // 
            // EventName
            // 
            EventName.AutoSize = true;
            EventName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            EventName.Location = new Point(24, 25);
            EventName.Name = "EventName";
            EventName.Size = new Size(210, 32);
            EventName.TabIndex = 0;
            EventName.Text = "Nazwa wydarzenia";
            // 
            // EventTime
            // 
            EventTime.AutoSize = true;
            EventTime.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            EventTime.Location = new Point(24, 67);
            EventTime.Name = "EventTime";
            EventTime.Size = new Size(152, 25);
            EventTime.TabIndex = 1;
            EventTime.Text = "Czas wydarzenia";
            // 
            // EventDesciption
            // 
            EventDesciption.AutoSize = true;
            EventDesciption.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            EventDesciption.Location = new Point(24, 123);
            EventDesciption.Name = "EventDesciption";
            EventDesciption.Size = new Size(151, 25);
            EventDesciption.TabIndex = 2;
            EventDesciption.Text = "Opis wydarzenia";
            // 
            // EditEventButton
            // 
            EditEventButton.Location = new Point(576, 409);
            EditEventButton.Name = "EditEventButton";
            EditEventButton.Size = new Size(94, 29);
            EditEventButton.TabIndex = 3;
            EditEventButton.Text = "Edytuj";
            EditEventButton.UseVisualStyleBackColor = true;
            // 
            // DeleteEventButton
            // 
            DeleteEventButton.Location = new Point(694, 409);
            DeleteEventButton.Name = "DeleteEventButton";
            DeleteEventButton.Size = new Size(94, 29);
            DeleteEventButton.TabIndex = 4;
            DeleteEventButton.Text = "Usuń";
            DeleteEventButton.UseVisualStyleBackColor = true;
            // 
            // EventDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DeleteEventButton);
            Controls.Add(EditEventButton);
            Controls.Add(EventDesciption);
            Controls.Add(EventTime);
            Controls.Add(EventName);
            Name = "EventDetails";
            Text = "EventDetails";
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