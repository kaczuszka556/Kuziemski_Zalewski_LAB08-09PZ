using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class TimeDisplay : UserControl, IDisposable
    {
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        public TimeDisplay()
        {
            InitializeComponent();
            UpdateTime();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(OnTick);
            timer.Start();
        }

        private void OnTick(object sender, EventArgs e)
        {
            UpdateTime();
        }

        private void UpdateTime()
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            string time = "";

            if (hh < 10)
                time += "0" + hh;
            else
                time += hh;

            time += ":";

            if (mm < 10)
                time += "0" + mm;
            else
                time += mm;
            time += ":";

            if (ss < 10)
                time += "0" + ss;
            else
                time += ss;

            TimeDisplayClock.Text = time;
            TimeDisplayDate.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
        }

        public void Dispose()
        {
            timer.Dispose();
        }
    }
}
