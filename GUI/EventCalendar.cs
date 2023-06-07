using Kuziemski_Zalewski_LAB08_09PZ_BK;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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

                int startingX = 0;

                foreach (Wydarzenie item in wydarzenia)
                {
                    int neighboursCount = wydarzenia
                        .Where(w =>
                        ((item.Poczatek <= w.Poczatek && item.Koniec >= w.Poczatek) ||
                        (item.Poczatek >= w.Poczatek && item.Koniec <= w.Koniec))
                        )
                        .ToList().Count;


                    Rectangle rectangle = new Rectangle();

                    if (neighboursCount > 1)
                    {
                        rectangle.X = startingX;
                        startingX += EventCalendarEventPanels[i].Width / neighboursCount;

                    }
                    else
                    {
                        rectangle.X = 0;
                        startingX = 0;
                    }

                    if (daysInWeek[i].Day != item.Poczatek.Day)
                        rectangle.Y = 0;
                    else
                        rectangle.Y = (EventCalendarEventPanels[i].Height / 24) * item.Poczatek.Hour;


                    rectangle.Width = neighboursCount != 1 ? EventCalendarEventPanels[i].Width / neighboursCount : EventCalendarEventPanels[i].Width;

                    if (item.Koniec.Day != item.Poczatek.Day && daysInWeek[i].Day != item.Koniec.Day)
                        rectangle.Height = EventCalendarEventPanels[i].Height;
                    else if (item.Koniec.Day != item.Poczatek.Day && daysInWeek[i].Day == item.Koniec.Day)
                        rectangle.Height = (EventCalendarEventPanels[i].Height / 24) * item.Koniec.Hour;
                    else
                        rectangle.Height = (EventCalendarEventPanels[i].Height / 24) * (item.Koniec.Hour - item.Poczatek.Hour);
                    
                    EventCalendarEventPanels[i].Events.Add(new EventDisplay(rectangle, item));

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

        public int PaddingRight { get; set; }
        public int PaddingLeft { get; set; }

        public EventCalendarEventPanel()
        {
            PaddingRight = 2; PaddingLeft = 5;
        }

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

            int cornerRadius = 4;

            for (int i = 0; i < Events.Count; i++)
            {
                Rectangle rect = Events[i].Rectangle;
                int x = rect.X;
                int y = rect.Y;
                int width = rect.Width - PaddingRight;
                int height = rect.Height;

                int diameter = 2 * cornerRadius;
                Rectangle arcRect = new Rectangle(x, y, diameter, diameter);
                GraphicsPath path = new GraphicsPath();

                //Top-left 
                path.AddArc(arcRect, 180, 90);
                path.AddLine(x + cornerRadius, y, x + width - cornerRadius, y);

                //Top-right 
                arcRect.X = x + width - diameter;
                path.AddArc(arcRect, 270, 90);
                path.AddLine(x + width, y + cornerRadius, x + width, y + height - cornerRadius);

                //Bottom-right 
                arcRect.Y = y + height - diameter;
                path.AddArc(arcRect, 0, 90);
                path.AddLine(x + width - cornerRadius, y + height, x + cornerRadius, y + height);

                //Bottom-left 
                arcRect.X = x;
                path.AddArc(arcRect, 90, 90);
                path.AddLine(x, y + height - cornerRadius, x, y + cornerRadius);

                e.Graphics.FillPath(brushes[i], path);
                e.Graphics.DrawPath(Pens.Black, path);
  
                e.Graphics.DrawString(Events[i].Wydarzenie.Nazwa, new Font("Arial", 10, GraphicsUnit.Point), Brushes.Black, arcRect.X, arcRect.Y);

            }

        }
    }
}
