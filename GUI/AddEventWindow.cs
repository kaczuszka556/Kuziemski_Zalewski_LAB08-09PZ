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
using System.Resources;
namespace GUI
{
    public partial class AddEventWindow : Form
    {
        PreferencjeService PreferencjeService = new PreferencjeService();
        ComponentResourceManager resources;
        ResourceManager GlobalLocalization = Properties.Lang.ResourceManager;

        private bool EditMode = false;
        private Wydarzenie Wydarzenie;
        
        public AddEventWindow()
        {
            PreferencjeService = new PreferencjeService();
            resources = new ComponentResourceManager(typeof(AddEventWindow));

            Wydarzenie = new Wydarzenie();

            System.Threading.Thread.CurrentThread.CurrentCulture =
                new System.Globalization.CultureInfo(PreferencjeService.PobierzJezyk());
            System.Threading.Thread.CurrentThread.CurrentUICulture =
                new System.Globalization.CultureInfo(PreferencjeService.PobierzJezyk());

            this.TopMost = true;
            InitializeComponent();
        }

        public AddEventWindow(Wydarzenie wydarzenie) :this()
        {
            Wydarzenie = wydarzenie;
            StartDatePicker.Value = wydarzenie.Poczatek;
            EndDatePicker.Value = wydarzenie.Koniec;
            StartTimePicker.Value = wydarzenie.Poczatek;
            EndTimePicker.Value = wydarzenie.Koniec;
            EventDescriptionInput.Text = wydarzenie.Opis;
            EventNameInput.Text = wydarzenie.Nazwa;
            EditMode = true;

        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(EventNameInput.Text) || string.IsNullOrWhiteSpace(EventDescriptionInput.Text))
            {
                MessageBox.Show(GlobalLocalization.GetString("AddEventWindow.FillAllFieldsMessage"), GlobalLocalization.GetString("AddEventWindow.ValidationError"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime StartDate = StartDatePicker.Value.Date;
            Wydarzenie.Poczatek= StartDate.Date.Add(StartTimePicker.Value.TimeOfDay);
            DateTime EndDate = EndDatePicker.Value.Date;
            Wydarzenie.Koniec = EndDate.Date.Add(EndTimePicker.Value.TimeOfDay);

            if (Wydarzenie.Koniec < Wydarzenie.Poczatek)
            {
                MessageBox.Show(GlobalLocalization.GetString("AddEventWindow.IncorrectDates"), GlobalLocalization.GetString("AddEventWindow.ValidationError"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Wydarzenie.Nazwa = EventNameInput.Text;
            Wydarzenie.Opis = EventDescriptionInput.Text;

            KalendarzService kalendarzService = new KalendarzService();

            try
            {
                kalendarzService.AddWydarznie(Wydarzenie);
                MessageBox.Show(GlobalLocalization.GetString("AddEventWindow.Success"), GlobalLocalization.GetString("AddEventWindow.SuccessTitle"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                GlobalEventManager.TriggerOnEventCalendarChanged();
            }
            catch (Exception ex)
            {
                MessageBox.Show(GlobalLocalization.GetString("AddEventWindow.UnkownError"), GlobalLocalization.GetString("AddEventWindow.ValidationError"), MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                this.Close();
            }

            

            
        }
    }
}
