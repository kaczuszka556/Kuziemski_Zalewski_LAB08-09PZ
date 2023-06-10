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
    public partial class EventDetails : Form
    {
        public Wydarzenie Wydarzenie { get; set; }
        private PreferencjeService PreferencjeService;
        public EventDetails(Wydarzenie wydarzenie)
        {
            PreferencjeService = new PreferencjeService();

            System.Threading.Thread.CurrentThread.CurrentCulture =
                new System.Globalization.CultureInfo(PreferencjeService.PobierzJezyk());
            System.Threading.Thread.CurrentThread.CurrentUICulture =
                new System.Globalization.CultureInfo(PreferencjeService.PobierzJezyk());
            InitializeComponent();

            Wydarzenie = wydarzenie;
            EventName.Text = wydarzenie.Nazwa;
            EventDesciption.Text = wydarzenie.Opis;
            EventTime.Text = wydarzenie.Poczatek.ToString("G") + " - " + wydarzenie.Koniec.ToString("G");

        }

        private void DeleteEventButton_Click(object sender, EventArgs e)
        {
            KalendarzService kalendarzService = new KalendarzService();

            kalendarzService.DeleteWydarzeniePoId(Wydarzenie.WydarzenieId);
            Close();
        }

        private void EditEventButton_Click(object sender, EventArgs e)
        {

        }
    }
}
