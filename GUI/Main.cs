using Kuziemski_Zalewski_LAB08_09PZ_BK;
using System.Net;

namespace GUI
{
    public partial class Main : Form
    {
        private DateTime CurrentDate = DateTime.Now;
        private int CurrentWeek = 1;
        private int HighlightedRow = 2;
        private int[,] CalendarBackColors = new int[6, 6];

        public Main()
        {
            InitializeComponent();
            this.Text = "Kalendarz";

            LeftKalendarzWypiszDni(CurrentDate.Month, CurrentDate.Year);
            //HighlightCurrentWeek();

        }

        private void LeftKalendarzWypiszDni(int miesiac, int rok)
        {
            LeftMiesiacRokLabel.Text = new DateTime(rok, miesiac, 1).ToString("MMMM yyyy").ToUpper();

            int pierwszyDzien = Narzêdziowa.PierwszyDzieñ(miesiac, rok) == 0 ? 6 : Narzêdziowa.PierwszyDzieñ(miesiac, rok) - 1;
            int dni = Narzêdziowa.DniWMiesiacu(miesiac, rok);
            int licznikDzien = 0;

            ClearCalendar();

            for (int row = 0; row < LeftKalendarzTable.RowCount; row++)
            {
                if (licznikDzien == dni)
                    break;
                for (int column = pierwszyDzien; column < LeftKalendarzTable.ColumnCount; column++)
                {
                    if (licznikDzien == dni)
                        break;
                    Control control = LeftKalendarzTable.GetControlFromPosition(column, row);
                    
                    if (control != null && control is Label label)
                    {
                        licznikDzien++;
                        label.Text = (licznikDzien).ToString();
                       //TODO
                        //label.Click -= CalendarDayClick;
                        //label.Click += (sender, e) =>
                        //{
                        //    CalendarDayClick(sender, new DayEventArgs(licznikDzien, miesiac, rok, row));
                        //};
                    }
                }

                pierwszyDzien = 0;
            }
        }

        private void CalendarDayClick(object sender, DayEventArgs e)
        {
          
        }


        private void HighlightCurrentWeek()
        {
            for (int column = 0; column < LeftKalendarzTable.ColumnCount; column++)
            {
                Control control = LeftKalendarzTable.GetControlFromPosition(column, CurrentWeek);
                if (control != null && control is Label label)
                {
                    label.BackColor = Color.White;
                }
            }
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

        private void ClearCalendar()
        {
            for (int row = 0; row < LeftKalendarzTable.RowCount; row++)
            {

                for (int column = 0; column < LeftKalendarzTable.ColumnCount; column++)
                {
                    Control control = LeftKalendarzTable.GetControlFromPosition(column, row);
                    if (control != null && control is Label label)
                    {
                        label.Text = "";
                    }
                }

            }
        }

        private void LeftCalendarNextMonth_Click(object sender, EventArgs e)
        {
            CurrentDate = CurrentDate.AddMonths(1);
            LeftKalendarzWypiszDni(CurrentDate.Month, CurrentDate.Year);
        }

        private void LeftCalendarPreviousMonth_Click(object sender, EventArgs e)
        {
            CurrentDate = CurrentDate.AddMonths(-1);
            LeftKalendarzWypiszDni(CurrentDate.Month, CurrentDate.Year);
        }


    }

    public class DayEventArgs
    {
        public int Day;
        public int Month;
        public int Year;
        public int Week;

        public DayEventArgs(int day, int month, int year, int week)
        {
            Day = day;
            Month = month;
            Year = year;
            Week = week;
        }
    }
}