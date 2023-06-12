using GUI.Extensions;
using Kuziemski_Zalewski_LAB08_09PZ_BK;
using System.Diagnostics;
using System.Net;
using System.Threading.Tasks;
namespace GUI
{
    public partial class Main : Form, IDisposable
    {


        private PreferencjeService PreferencjeService;

        public Main()
        {
            PreferencjeService = new PreferencjeService();

            System.Threading.Thread.CurrentThread.CurrentCulture =
                new System.Globalization.CultureInfo(PreferencjeService.PobierzJezyk());
            System.Threading.Thread.CurrentThread.CurrentUICulture =
                new System.Globalization.CultureInfo(PreferencjeService.PobierzJezyk());

            GlobalEventManager.OnLanguageChanged += UpdateLanguage;
            GlobalEventManager.OnEventCalendarChanged += UpdateCalendar;

            InitializeComponent();
            TimeDisplay.OnCurrentDateLinkClicked += dayCalendar.ChangeToCurrentDate;
            TimeDisplay.Start();

            dayCalendar.OnEventCalendarDayUpdate += UpdateCalendar;

            EventCalendar.UpdateEventCalendarDayLabels(dayCalendar.CurrentDate.Year, dayCalendar.CurrentDate.Month, dayCalendar.HighlightedRow + 1);


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

        }

        private void UpdateCalendar()
        {
            EventCalendar.UpdateEventCalendarDayLabels(dayCalendar.CurrentDate.Year, dayCalendar.CurrentDate.Month, dayCalendar.HighlightedRow + 1);
        }

        private void UpdateCalendar(int year, int month, int week)
        {
            EventCalendar.UpdateEventCalendarDayLabels(year, month, week);
        }

        public void Dispose()
        {
            GlobalEventManager.OnLanguageChanged -= UpdateLanguage;
            GlobalEventManager.OnEventCalendarChanged -= UpdateCalendar;

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




}


