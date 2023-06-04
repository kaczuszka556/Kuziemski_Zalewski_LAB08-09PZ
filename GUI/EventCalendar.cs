using Kuziemski_Zalewski_LAB08_09PZ_BK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class EventCalendar : UserControl
    {
        private EventCalendarDayLabel[] EventCalendarDayLabels;

        public EventCalendar()
        {
            InitializeComponent();

            EventCalendarDayLabels = new EventCalendarDayLabel[]
            {
                EventCalendarDay1,
                EventCalendarDay2,
                EventCalendarDay3,
                EventCalendarDay4,
                EventCalendarDay5,
                EventCalendarDay6,
                EventCalendarDay7
            };
        }

        public void UpdateEventCalendarDayLabels(int year, int month, int week)
        {
            DateOnly[] daysInWeek = Narzędziowa.WszystkieDniWtygodniuPoNumerze(week, month, year);

            for (int i = 0; i < daysInWeek.Length; i++)
            {
                EventCalendarDayLabels[i].Text = daysInWeek[i].ToString();
            }
        }

    }
}
