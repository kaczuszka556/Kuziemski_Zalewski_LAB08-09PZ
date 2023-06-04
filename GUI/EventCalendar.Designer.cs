﻿namespace GUI
{
    partial class EventCalendar
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
            tableLayoutPanel1 = new TableLayoutPanel();
            EventCalendarDay7 = new EventCalendarDayLabel();
            EventCalendarDay6 = new EventCalendarDayLabel();
            EventCalendarDay5 = new EventCalendarDayLabel();
            EventCalendarDay4 = new EventCalendarDayLabel();
            EventCalendarDay3 = new EventCalendarDayLabel();
            EventCalendarDay2 = new EventCalendarDayLabel();
            EventCalendarDay1 = new EventCalendarDayLabel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.28571F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857161F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857161F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857161F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857161F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857161F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857161F));
            tableLayoutPanel1.Controls.Add(EventCalendarDay7, 6, 0);
            tableLayoutPanel1.Controls.Add(EventCalendarDay6, 5, 0);
            tableLayoutPanel1.Controls.Add(EventCalendarDay5, 4, 0);
            tableLayoutPanel1.Controls.Add(EventCalendarDay4, 3, 0);
            tableLayoutPanel1.Controls.Add(EventCalendarDay3, 2, 0);
            tableLayoutPanel1.Controls.Add(EventCalendarDay2, 1, 0);
            tableLayoutPanel1.Controls.Add(EventCalendarDay1, 0, 0);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.Size = new Size(1145, 722);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // EventCalendarDay7
            // 
            EventCalendarDay7.AutoSize = true;
            EventCalendarDay7.Dock = DockStyle.Fill;
            EventCalendarDay7.Location = new Point(982, 1);
            EventCalendarDay7.Name = "EventCalendarDay7";
            EventCalendarDay7.Size = new Size(159, 71);
            EventCalendarDay7.TabIndex = 6;
            EventCalendarDay7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EventCalendarDay6
            // 
            EventCalendarDay6.AutoSize = true;
            EventCalendarDay6.Dock = DockStyle.Fill;
            EventCalendarDay6.Location = new Point(819, 1);
            EventCalendarDay6.Name = "EventCalendarDay6";
            EventCalendarDay6.Size = new Size(156, 71);
            EventCalendarDay6.TabIndex = 5;
            EventCalendarDay6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EventCalendarDay5
            // 
            EventCalendarDay5.AutoSize = true;
            EventCalendarDay5.Dock = DockStyle.Fill;
            EventCalendarDay5.Location = new Point(656, 1);
            EventCalendarDay5.Name = "EventCalendarDay5";
            EventCalendarDay5.Size = new Size(156, 71);
            EventCalendarDay5.TabIndex = 4;
            EventCalendarDay5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EventCalendarDay4
            // 
            EventCalendarDay4.AutoSize = true;
            EventCalendarDay4.Dock = DockStyle.Fill;
            EventCalendarDay4.Location = new Point(493, 1);
            EventCalendarDay4.Name = "EventCalendarDay4";
            EventCalendarDay4.Size = new Size(156, 71);
            EventCalendarDay4.TabIndex = 3;
            EventCalendarDay4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EventCalendarDay3
            // 
            EventCalendarDay3.AutoSize = true;
            EventCalendarDay3.Dock = DockStyle.Fill;
            EventCalendarDay3.Location = new Point(330, 1);
            EventCalendarDay3.Name = "EventCalendarDay3";
            EventCalendarDay3.Size = new Size(156, 71);
            EventCalendarDay3.TabIndex = 2;
            EventCalendarDay3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EventCalendarDay2
            // 
            EventCalendarDay2.AutoSize = true;
            EventCalendarDay2.Dock = DockStyle.Fill;
            EventCalendarDay2.Location = new Point(167, 1);
            EventCalendarDay2.Name = "EventCalendarDay2";
            EventCalendarDay2.Size = new Size(156, 71);
            EventCalendarDay2.TabIndex = 1;
            EventCalendarDay2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EventCalendarDay1
            // 
            EventCalendarDay1.AutoSize = true;
            EventCalendarDay1.Dock = DockStyle.Fill;
            EventCalendarDay1.Location = new Point(4, 1);
            EventCalendarDay1.Name = "EventCalendarDay1";
            EventCalendarDay1.Size = new Size(156, 71);
            EventCalendarDay1.TabIndex = 0;
            EventCalendarDay1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EventCalendar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "EventCalendar";
            Size = new Size(1157, 742);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private EventCalendarDayLabel EventCalendarDay7;
        private EventCalendarDayLabel EventCalendarDay6;
        private EventCalendarDayLabel EventCalendarDay5;
        private EventCalendarDayLabel EventCalendarDay4;
        private EventCalendarDayLabel EventCalendarDay3;
        private EventCalendarDayLabel EventCalendarDay2;
        private EventCalendarDayLabel EventCalendarDay1;
    }
}