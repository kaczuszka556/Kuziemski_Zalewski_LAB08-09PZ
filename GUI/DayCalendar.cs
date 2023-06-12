using GUI.Extensions;
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
    public partial class DayCalendar : UserControl, IDisposable
    {
        public DateTime CurrentDate { get; private set; } = DateTime.Now;
        public int HighlightedRow { get; private set; } = 0;

        public delegate void EventCalendarDayUpdate(int year, int month, int week);
        public event EventCalendarDayUpdate OnEventCalendarDayUpdate;

        public PreferencjeService PreferencjeService { get; }

        public DayCalendar()
        {
            PreferencjeService = new PreferencjeService();

            InitializeComponent();

            GlobalEventManager.OnLanguageChanged += UpdateLanguage;
            HighlightedRow = Narzędziowa.KtóryTydzień(new DateOnly(CurrentDate.Year, CurrentDate.Month, CurrentDate.Day)) - 1;
            LeftKalendarzWypiszDni(CurrentDate.Month, CurrentDate.Year);
        }

        private void UpdateLanguage()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture =
                new System.Globalization.CultureInfo(PreferencjeService.PobierzJezyk());
            System.Threading.Thread.CurrentThread.CurrentUICulture =
                new System.Globalization.CultureInfo(PreferencjeService.PobierzJezyk());

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));

            IEnumerable<Control> list = this.GetAllControls();
            foreach (Control item in list)
            {
                resources.ApplyResources(item, item.Name);
            }
            MonthYearLabel.Text = new DateTime(CurrentDate.Year, CurrentDate.Month, 1).ToString("MMMM yyyy").ToUpper();
        }

        public void Dispose()
        {
            GlobalEventManager.OnLanguageChanged -= UpdateLanguage;

        }

        private void LeftKalendarzWypiszDni(int miesiac, int rok)
        {
            MonthYearLabel.Text = new DateTime(rok, miesiac, 1).ToString("MMMM yyyy").ToUpper();

            int pierwszyDzien = Narzędziowa.PierwszyDzień(miesiac, rok) == 0 ? 6 : Narzędziowa.PierwszyDzień(miesiac, rok) - 1;
            int dni = Narzędziowa.DniWMiesiacu(miesiac, rok);
            int licznikDzien = 1;
            int licznikPrzed = CurrentDate.Month == 1 ? Narzędziowa.DniWMiesiacu(12, CurrentDate.Year - 1) : Narzędziowa.DniWMiesiacu(CurrentDate.Month - 1, CurrentDate.Year);
            int licznikPoza = 1;
            ClearCalendar();

            for (int column = pierwszyDzien - 1; column >= 0; column--)
            {
                Control control = CalendarTable.GetControlFromPosition(column, 0);
                if (control != null && control is CalendarDayLabel label)
                {
                    label.Day = licznikPrzed;
                    label.PreviousMonth = true;
                    label.Text = (licznikPrzed).ToString();
                    label.ForeColor = Color.Gray;
                    licznikPrzed--;
                }
            }

            for (int row = 0; row < CalendarTable.RowCount; row++)
            {

                for (int column = pierwszyDzien; column < CalendarTable.ColumnCount; column++)
                {
                    Control control = CalendarTable.GetControlFromPosition(column, row);
                    if (control != null && control is CalendarDayLabel label)
                    {

                        if(DateTime.Now.Date == CurrentDate.Date && licznikDzien == CurrentDate.Day)
                        {
                            label.BorderStyle = BorderStyle.FixedSingle;
                        }

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
                    HighlightedRow = Narzędziowa.KtóryTydzień(
                        new DateOnly(
                            CurrentDate.Month == 12 ? CurrentDate.Year + 1 : CurrentDate.Year,
                            CurrentDate.Month == 12 ? 1 : CurrentDate.Month + 1,
                            cal.Day)
                        ) - 1;

                    ChangeCalendarMonth(1);

                }
                else if (cal.PreviousMonth)
                {
                    HighlightedRow = Narzędziowa.KtóryTydzień(
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

            CalendarTable.Invalidate();
            OnEventCalendarDayUpdate(CurrentDate.Year, CurrentDate.Month, HighlightedRow + 1);

        }

        private void ChangeCalendarMonth(int numberOfMonths)
        {
            CurrentDate = CurrentDate.AddMonths(numberOfMonths);
            CalendarTable.Invalidate();
            LeftKalendarzWypiszDni(CurrentDate.Month, CurrentDate.Year);
            OnEventCalendarDayUpdate(CurrentDate.Year, CurrentDate.Month, HighlightedRow + 1);
        }

        private void ClearCalendar()
        {
            for (int row = 0; row < CalendarTable.RowCount; row++)
            {

                for (int column = 0; column < CalendarTable.ColumnCount; column++)
                {
                    Control control = CalendarTable.GetControlFromPosition(column, row);
                    if (control != null && control is CalendarDayLabel label)
                    {
                        label.BorderStyle = BorderStyle.None;
                        label.PreviousMonth = false;
                        label.NextMonth = false;
                        label.Text = "";
                    }
                }

            }
        }

        private void CalendarNextMonth_Click(object sender, EventArgs e)
        {
            ChangeCalendarMonth(1);
        }

        private void CalendarPreviousMonth_Click(object sender, EventArgs e)
        {
            ChangeCalendarMonth(-1);
        }

        private void LeftKalendarzTable_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if (HighlightedRow == e.Row)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.White), e.CellBounds);
            }
        }

        public void ChangeToCurrentDate()
        {
            CurrentDate = DateTime.Now;
            HighlightedRow = Narzędziowa.KtóryTydzień(new DateOnly(CurrentDate.Year, CurrentDate.Month, CurrentDate.Day)) - 1;
            LeftKalendarzWypiszDni(CurrentDate.Month, CurrentDate.Year);
            OnEventCalendarDayUpdate(CurrentDate.Year, CurrentDate.Month, HighlightedRow + 1);
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


