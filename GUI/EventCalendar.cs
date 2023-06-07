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
        private EventCalendarEventPanel[] EventCalendarEventPanels;
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

            EventCalendarEventPanels = new EventCalendarEventPanel[]
            {
                EventCalendarEventPanel1,
                EventCalendarEventPanel2,
                EventCalendarEventPanel3,
                EventCalendarEventPanel4,
                EventCalendarEventPanel5,
                EventCalendarEventPanel6,
                EventCalendarEventPanel7,
            };
        }



        public void UpdateEventCalendarDayLabels(int year, int month, int week)
        {
            DateOnly[] daysInWeek = Narzędziowa.WszystkieDniWtygodniuPoNumerze(week, month, year);
            KalendarzService kalendarzService = new KalendarzService();
            for (int i = 0; i < daysInWeek.Length; i++)
            {
                EventCalendarDayLabels[i].Text = daysInWeek[i].ToString();
                EventCalendarEventPanels[i].Events.Clear();
                List<Wydarzenie> wydarzenia = kalendarzService.ZnajdżWydarzeniaDnia(daysInWeek[i]);

                foreach (Wydarzenie item in wydarzenia)
                {

                    Rectangle rectangle = new Rectangle();
                    rectangle.X = 0;

                    if(daysInWeek[i].Day != item.Poczatek.Day)
                        rectangle.Y = 0;
                    else
                        rectangle.Y = (EventCalendarEventPanels[i].Height / 24) * item.Poczatek.Hour;
                    rectangle.Width = EventCalendarEventPanels[i].Width / wydarzenia.Count;

                    if(item.Koniec.Day != item.Poczatek.Day && daysInWeek[i].Day != item.Koniec.Day)
                        rectangle.Height = (EventCalendarEventPanels[i].Height / 24) * (24 - item.Poczatek.Hour);
                    else if(item.Koniec.Day != item.Poczatek.Day && daysInWeek[i].Day == item.Koniec.Day)
                        rectangle.Height = (EventCalendarEventPanels[i].Height / 24) * item.Koniec.Hour;
                    else
                        rectangle.Height = (EventCalendarEventPanels[i].Height / 24) *  (item.Koniec.Hour - item.Poczatek.Hour);
                    EventCalendarEventPanels[i].Events.Add(new EventDisplay(rectangle, item));
                    //EventCalendarEventPanels[i].Text += item.ToString();
                }
                EventCalendarEventPanels[i].Refresh();
            }
        }

    }

    public class EventDisplay
    {
        public Rectangle Rectangle { get; set; }
        public Wydarzenie Wydarzenie { get; set; }

        public EventDisplay(Rectangle rectangle, Wydarzenie wydarzenie)
        {
            Rectangle = rectangle;
            Wydarzenie = wydarzenie;
        }
    }

    public class EventCalendarDayLabel : Label
    {

    }

    public class EventCalendarEventPanel : Panel
    {
        private List<Brush> brushes = new List<Brush>()
        {
            Brushes.Green,
            Brushes.Blue,
            Brushes.Magenta,
            Brushes.Yellow,
            Brushes.Orange
        };
        public List<EventDisplay> Events { get; } = new List<EventDisplay>();

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            for (int i = 0; i < Events.Count; i++)
            {
                e.Graphics.FillRectangle(brushes[i], Events[i].Rectangle);
            }

        }
    }
}
