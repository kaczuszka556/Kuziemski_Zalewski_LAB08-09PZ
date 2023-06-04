using Kuziemski_Zalewski_LAB08_09PZ_BK;
using System.Diagnostics;
using System.Net;

namespace GUI
{
    public partial class Main : Form
    {
        private DateTime CurrentDate = DateTime.Now;
        private int HighlightedRow = 0;
        private EventCalendarDayLabel[] EventCalendarDayLabels;

        public Main()
        {
            InitializeComponent();
            this.Text = "Kalendarz";
            HighlightedRow = Narz�dziowa.Kt�ryTydzie�(new DateOnly(CurrentDate.Year, CurrentDate.Month, CurrentDate.Day)) - 1;
            LeftKalendarzWypiszDni(CurrentDate.Month, CurrentDate.Year);

            EventCalendarDayLabels = new EventCalendarDayLabel[]
            {
                EventCalendarDay1,
                EventCalendarDay2,
                EventCalendarDay3,
                EventCalendarDay4,
                EventCalendarDay5,
                EventCalendarDay6,
                EventCalendarDay7,
            };

            UpdateEventCalendarDayLabels();


        }

        private void LeftKalendarzWypiszDni(int miesiac, int rok)
        {
            LeftMiesiacRokLabel.Text = new DateTime(rok, miesiac, 1).ToString("MMMM yyyy").ToUpper();

            int pierwszyDzien = Narz�dziowa.PierwszyDzie�(miesiac, rok) == 0 ? 6 : Narz�dziowa.PierwszyDzie�(miesiac, rok) - 1;
            int dni = Narz�dziowa.DniWMiesiacu(miesiac, rok);
            int licznikDzien = 1;
            int licznikPrzed = CurrentDate.Month == 1 ? Narz�dziowa.DniWMiesiacu(12, CurrentDate.Year - 1) : Narz�dziowa.DniWMiesiacu(CurrentDate.Month - 1, CurrentDate.Year);
            int licznikPoza = 1;
            ClearCalendar();

            for (int column = pierwszyDzien - 1; column >= 0; column--)
            {
                Control control = LeftKalendarzTable.GetControlFromPosition(column, 0);
                if (control != null && control is CalendarDayLabel label)
                {
                    label.Day = licznikPrzed;
                    label.PreviousMonth = true;
                    label.Text = (licznikPrzed).ToString();
                    label.ForeColor = Color.Gray;
                    licznikPrzed--;
                }
            }

            for (int row = 0; row < LeftKalendarzTable.RowCount; row++)
            {

                for (int column = pierwszyDzien; column < LeftKalendarzTable.ColumnCount; column++)
                {
                    Control control = LeftKalendarzTable.GetControlFromPosition(column, row);
                    if (control != null && control is CalendarDayLabel label)
                    {

                        if (licznikDzien > dni)
                        {
                            label.Day = licznikPoza;
                            label.NextMonth = true;
                            label.Text = (licznikPoza).ToString();
                            label.ForeColor = Color.Gray;
                            licznikPoza++;
                        }
                        else
                        {
                            label.Day = licznikDzien;
                            label.Text = (licznikDzien).ToString();
                            label.ForeColor = Color.Black;
                            licznikDzien++;
                        }

                    }


                }

                pierwszyDzien = 0;
            }
        }

        private void CalendarDayClick(object sender, EventArgs e)
        {
            if (sender is CalendarDayLabel cal)
            {
                if (cal.NextMonth)
                {
                    HighlightedRow = Narz�dziowa.Kt�ryTydzie�(
                        new DateOnly(
                            CurrentDate.Month == 12 ? CurrentDate.Year + 1 : CurrentDate.Year,
                            CurrentDate.Month == 12 ? 1 : CurrentDate.Month + 1,
                            cal.Day)
                        ) - 1;

                    ChangeCalendarMonth(1);

                }
                else if (cal.PreviousMonth)
                {
                    HighlightedRow = Narz�dziowa.Kt�ryTydzie�(
                        new DateOnly(
                            CurrentDate.Month == 1 ? CurrentDate.Year - 1 : CurrentDate.Year,
                            CurrentDate.Month == 1 ? 12 : CurrentDate.Month - 1,
                            cal.Day)
                        ) - 1;

                    if (HighlightedRow < 0)
                        HighlightedRow = 5;
                    ChangeCalendarMonth(-1);

                }
                else
                {
                    HighlightedRow = cal.Week;
                }


            }

            LeftKalendarzTable.Invalidate();
            UpdateEventCalendarDayLabels();


        }

        private void LeftKalendarzTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LeftKalendarzTable_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if (HighlightedRow == e.Row)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.White), e.CellBounds);
            }
        }

        private void UpdateEventCalendarDayLabels()
        {
            DateOnly[] daysInWeek = Narz�dziowa.WszystkieDniWtygodniuPoNumerze(HighlightedRow + 1, CurrentDate.Month, CurrentDate.Year);

            for (int i = 0; i < daysInWeek.Length; i++)
            {
                EventCalendarDayLabels[i].Text = daysInWeek[i].ToString();

            }
        }

        private void ClearCalendar()
        {
            for (int row = 0; row < LeftKalendarzTable.RowCount; row++)
            {

                for (int column = 0; column < LeftKalendarzTable.ColumnCount; column++)
                {
                    Control control = LeftKalendarzTable.GetControlFromPosition(column, row);
                    if (control != null && control is CalendarDayLabel label)
                    {
                        label.PreviousMonth = false;
                        label.NextMonth = false;
                        label.Text = "";
                    }
                }

            }
        }

        private void ChangeCalendarMonth(int numberOfMonths)
        {
            CurrentDate = CurrentDate.AddMonths(numberOfMonths);
            LeftKalendarzWypiszDni(CurrentDate.Month, CurrentDate.Year);
            UpdateEventCalendarDayLabels();
        }

        private void LeftCalendarNextMonth_Click(object sender, EventArgs e)
        {
            ChangeCalendarMonth(1);
        }

        private void LeftCalendarPreviousMonth_Click(object sender, EventArgs e)
        {
            ChangeCalendarMonth(-1);
        }

        private void NewEventMenuButton_Click(object sender, EventArgs e)
        {
            AddEventWindow floatingWindow = new AddEventWindow();
            floatingWindow.ShowDialog();

        }
    }

    public class DayEventArgs
    {
        public int Week;

        public DayEventArgs(int week)
        {
            Week = week;
        }
    }

    public class CalendarDayLabel : Label
    {
        public int Week { get; set; }
        public bool PreviousMonth { get; set; }
        public bool NextMonth { get; set; }

        public int Day { get; set; }

    }

    public class EventCalendarDayLabel : Label
    {

    }
}