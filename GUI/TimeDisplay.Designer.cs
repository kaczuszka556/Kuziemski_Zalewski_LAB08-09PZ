namespace GUI
{
    partial class TimeDisplay
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
            TimeDisplayClock = new Label();
            TimeDisplayDate = new LinkLabel();
            SuspendLayout();
            // 
            // TimeDisplayClock
            // 
            TimeDisplayClock.AutoSize = true;
            TimeDisplayClock.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            TimeDisplayClock.Location = new Point(13, 16);
            TimeDisplayClock.Name = "TimeDisplayClock";
            TimeDisplayClock.Size = new Size(173, 54);
            TimeDisplayClock.TabIndex = 0;
            TimeDisplayClock.Text = "00:00:00";
            // 
            // TimeDisplayDate
            // 
            TimeDisplayDate.AutoSize = true;
            TimeDisplayDate.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            TimeDisplayDate.Location = new Point(13, 83);
            TimeDisplayDate.Name = "TimeDisplayDate";
            TimeDisplayDate.Size = new Size(288, 37);
            TimeDisplayDate.TabIndex = 1;
            TimeDisplayDate.TabStop = true;
            TimeDisplayDate.Text = "dddd, dd MMMM yyyy";
            // 
            // TimeDisplay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TimeDisplayDate);
            Controls.Add(TimeDisplayClock);
            Name = "TimeDisplay";
            Size = new Size(432, 137);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TimeDisplayClock;
        private LinkLabel TimeDisplayDate;
    }
}
