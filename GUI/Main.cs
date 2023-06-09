using Kuziemski_Zalewski_LAB08_09PZ_BK;
using System.Diagnostics;
using System.Net;
using System.Threading.Tasks;
namespace GUI
{
    public partial class Main : Form
    {
        private DateTime CurrentDate = DateTime.Now;
        private int HighlightedRow = 0;

        private PreferencjeService PreferencjeService;

        public Main()
        {
            PreferencjeService = new PreferencjeService();

            System.Threading.Thread.CurrentThread.CurrentCulture =
                new System.Globalization.CultureInfo(PreferencjeService.PobierzJezyk());
            System.Threading.Thread.CurrentThread.CurrentUICulture =
                new System.Globalization.CultureInfo(PreferencjeService.PobierzJezyk());

            InitializeComponent();
            TimeDisplay.OnCurrentDateLinkClicked += ChangeToCurrentDate;
            HighlightedRow = Narzêdziowa.KtóryTydzieñ(new DateOnly(CurrentDate.Year, CurrentDate.Month, CurrentDate.Day)) - 1;
            LeftKalendarzWypiszDni(CurrentDate.Month, CurrentDate.Year);

            EventCalendar.UpdateEventCalendarDayLabels(CurrentDate.Year, CurrentDate.Month, HighlightedRow + 1);


        }

        private void LeftKalendarzWypiszDni(int miesiac, int rok)
        {
            LeftMiesiacRokLabel.Text = new DateTime(rok, miesiac, 1).ToString("MMMM yyyy").ToUpper();

            int pierwszyDzien = Narzêdziowa.PierwszyDzieñ(miesiac, rok) == 0 ? 6 : Narzêdziowa.PierwszyDzieñ(miesiac, rok) - 1;
            int dni = Narzêdziowa.DniWMiesiacu(miesiac, rok);
            int licznikDzien = 1;
            int licznikPrzed = CurrentDate.Month == 1 ? Narzêdziowa.DniWMiesiacu(12, CurrentDate.Year - 1) : Narzêdziowa.DniWMiesiacu(CurrentDate.Month - 1, CurrentDate.Year);
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
                    HighlightedRow = Narzêdziowa.KtóryTydzieñ(
                        new DateOnly(
                            CurrentDate.Month == 12 ? CurrentDate.Year + 1 : CurrentDate.Year,
                            CurrentDate.Month == 12 ? 1 : CurrentDate.Month + 1,
                            cal.Day)
                        ) - 1;

                    ChangeCalendarMonth(1);

                }
                else if (cal.PreviousMonth)
                {
                    HighlightedRow = Narzêdziowa.KtóryTydzieñ(
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
            EventCalendar.UpdateEventCalendarDayLabels(CurrentDate.Year, CurrentDate.Month, HighlightedRow + 1);


        }

        private void LeftKalendarzTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ChangeToCurrentDate()
        {
            CurrentDate = DateTime.Now;
            HighlightedRow = Narzêdziowa.KtóryTydzieñ(new DateOnly(CurrentDate.Year, CurrentDate.Month, CurrentDate.Day)) - 1;
            LeftKalendarzWypiszDni(CurrentDate.Month, CurrentDate.Year);
            EventCalendar.UpdateEventCalendarDayLabels(CurrentDate.Year, CurrentDate.Month, HighlightedRow + 1);
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
            EventCalendar.UpdateEventCalendarDayLabels(CurrentDate.Year, CurrentDate.Month, HighlightedRow + 1);
        }

        private void LeftCalendarNextMonth_Click(object sender, EventArgs e)
        {
            ChangeCalendarMonth(1);
        }

        private void LeftCalendarPreviousMonth_Click(object sender, EventArgs e)
        {
            ChangeCalendarMonth(-1);
        }

        private void opcjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OptionsWindow optionsWindow = new OptionsWindow();

            optionsWindow.ShowDialog();
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


}

public class Zegar : Panel, IDisposable
{
    System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

    public Zegar()
    {
        timer.Interval = 1000;
        timer.Tick += new EventHandler(OnTick);
        timer.Start();
    }

    private void OnTick(object sender, EventArgs e)
    {
        //get current time
        int hh = DateTime.Now.Hour;
        int mm = DateTime.Now.Minute;
        int ss = DateTime.Now.Second;

        //time
        string time = "";

        //padding leading zero
        if (hh < 10)
        {
            time += "0" + hh;
        }
        else
        {
            time += hh;
        }
        time += ":";

        if (mm < 10)
        {
            time += "0" + mm;
        }
        else
        {
            time += mm;
        }
        time += ":";

        if (ss < 10)
        {
            time += "0" + ss;
        }
        else
        {
            time += ss;
        }

        //update label
        this.Text = time;
    }

    public void Dispose()
    {
        timer.Dispose();
    }
}
