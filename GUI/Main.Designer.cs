namespace GUI
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            menuStrip1 = new MenuStrip();
            plikToolStripMenuItem = new ToolStripMenuItem();
            NewEventMenuButton = new ToolStripMenuItem();
            opcjeToolStripMenuItem = new ToolStripMenuItem();
            wyjdźToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel4 = new TableLayoutPanel();
            label17 = new Label();
            label18 = new Label();
            EventCalendar = new EventCalendar();
            TimeDisplay = new TimeDisplay();
            dayCalendar = new DayCalendar();
            menuStrip1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { plikToolStripMenuItem });
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.Name = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            plikToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { NewEventMenuButton, opcjeToolStripMenuItem, wyjdźToolStripMenuItem });
            plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            resources.ApplyResources(plikToolStripMenuItem, "plikToolStripMenuItem");
            // 
            // NewEventMenuButton
            // 
            NewEventMenuButton.Name = "NewEventMenuButton";
            resources.ApplyResources(NewEventMenuButton, "NewEventMenuButton");
            NewEventMenuButton.Click += NewEventMenuButton_Click;
            // 
            // opcjeToolStripMenuItem
            // 
            opcjeToolStripMenuItem.Name = "opcjeToolStripMenuItem";
            resources.ApplyResources(opcjeToolStripMenuItem, "opcjeToolStripMenuItem");
            opcjeToolStripMenuItem.Click += opcjeToolStripMenuItem_Click;
            // 
            // wyjdźToolStripMenuItem
            // 
            wyjdźToolStripMenuItem.Name = "wyjdźToolStripMenuItem";
            resources.ApplyResources(wyjdźToolStripMenuItem, "wyjdźToolStripMenuItem");
            // 
            // tableLayoutPanel4
            // 
            resources.ApplyResources(tableLayoutPanel4, "tableLayoutPanel4");
            tableLayoutPanel4.Controls.Add(label17, 0, 5);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // label17
            // 
            resources.ApplyResources(label17, "label17");
            label17.Name = "label17";
            // 
            // label18
            // 
            resources.ApplyResources(label18, "label18");
            label18.Name = "label18";
            // 
            // EventCalendar
            // 
            resources.ApplyResources(EventCalendar, "EventCalendar");
            EventCalendar.Name = "EventCalendar";
            // 
            // TimeDisplay
            // 
            resources.ApplyResources(TimeDisplay, "TimeDisplay");
            TimeDisplay.Name = "TimeDisplay";
            // 
            // dayCalendar
            // 
            resources.ApplyResources(dayCalendar, "dayCalendar");
            dayCalendar.Name = "dayCalendar";
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dayCalendar);
            Controls.Add(TimeDisplay);
            Controls.Add(EventCalendar);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Main";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem plikToolStripMenuItem;
        private ToolStripMenuItem opcjeToolStripMenuItem;
        private ToolStripMenuItem wyjdźToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label17;
        private Label label18;
        private ToolStripMenuItem NewEventMenuButton;
        private EventCalendar EventCalendar;
        private TimeDisplay TimeDisplay;
        private DayCalendar dayCalendar;
    }
}