using Kuziemski_Zalewski_LAB08_09PZ_BK;
using System.Diagnostics;
using System.Net;

namespace GUI
{
    public partial class Main : Form
    {
        private DateTime CurrentDate = DateTime.Now;
        private int HighlightedRow = 0;
        private int[,] CalendarBackColors = new int[6, 6];

        public Main()
        {
            InitializeComponent();
            this.Text = "Kalendarz";
            HighlightedRow = Narzêdziowa.KtóryTydzieñ(new DateOnly(CurrentDate.Year, CurrentDate.Month, CurrentDate.Day)) -1;
            LeftKalendarzWypiszDni(CurrentDate.Month, CurrentDate.Year);
            //HighlightCurrentWeek();

        }

        private void LeftKalendarzWypiszDni(int miesiac, int rok)
        {
            LeftMiesiacRokLabel.Text = new DateTime(rok, miesiac, 1).ToString("MMMM yyyy").ToUpper();

            int pierwszyDzien = Narzêdziowa.PierwszyDzieñ(miesiac, rok) == 0 ? 6 : Narzêdziowa.PierwszyDzieñ(miesiac, rok) - 1;
            int dni = Narzêdziowa.DniWMiesiacu(miesiac, rok);
            int licznikDzien = 0;
            int licznikPrzed = CurrentDate.Month == 0 ? Narzêdziowa.DniWMiesiacu(12, CurrentDate.Year - 1) : Narzêdziowa.DniWMiesiacu(CurrentDate.Month-1, CurrentDate.Year);
            int licznikPoza = 0;
            ClearCalendar();

            for (int column = pierwszyDzien - 1; column >= 0; column--)
            {
                Control control = LeftKalendarzTable.GetControlFromPosition(column, 0);
                if (control != null && control is Label label)
                {
                    label.Text = (licznikPrzed--).ToString();
                    label.ForeColor = Color.Gray;
                }
            }

            for (int row = 0; row < LeftKalendarzTable.RowCount; row++)
            {

                for (int column = pierwszyDzien; column < LeftKalendarzTable.ColumnCount; column++)
                {
                    Control control = LeftKalendarzTable.GetControlFromPosition(column, row);
                    if (control != null && control is Label label)
                    {
                        if (licznikDzien == dni)
                        {
                            label.Text = (++licznikPoza).ToString();
                            label.ForeColor = Color.Gray;
                        }
                        else
                        {
                            label.Text = (++licznikDzien).ToString();
                            label.ForeColor = Color.Black;
                        }
                        
                    }
                    
                    
                }

                pierwszyDzien = 0;
            }
        }

        private void CalendarDayClick(object sender, EventArgs e)
        {
            if (sender is CalendarDayLabel cal)
                HighlightedRow = cal.Week;
            LeftKalendarzTable.Invalidate();

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
        public int Week;

        public DayEventArgs(int week)
        {
            Week = week;
        }
    }

    public class CalendarDayLabel : Label
    {
        public int Week { get; set; }

    }
}