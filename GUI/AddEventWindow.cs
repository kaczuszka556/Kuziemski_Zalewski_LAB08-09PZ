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

        public AddEventWindow()
        {
            PreferencjeService = new PreferencjeService();
            resources = new ComponentResourceManager(typeof(AddEventWindow));


            System.Threading.Thread.CurrentThread.CurrentCulture =
                new System.Globalization.CultureInfo(PreferencjeService.PobierzJezyk());
            System.Threading.Thread.CurrentThread.CurrentUICulture =
                new System.Globalization.CultureInfo(PreferencjeService.PobierzJezyk());

            this.TopMost = true;
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(EventNameInput.Text) || string.IsNullOrWhiteSpace(EventDescriptionInput.Text))
            {
                MessageBox.Show(GlobalLocalization.GetString("AddEventWindow.FillAllFieldsMessage"), GlobalLocalization.GetString("AddEventWindow.ValidationError"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime StartDate = StartDatePicker.Value.Date;
            StartDate = StartDate.Date.Add(StartTimePicker.Value.TimeOfDay);
            DateTime EndDate = EndDatePicker.Value.Date;
            EndDate = EndDate.Date.Add(EndTimePicker.Value.TimeOfDay);

            if (EndDate < StartDate)
            {
                MessageBox.Show(GlobalLocalization.GetString("AddEventWindow.IncorrectDates"), GlobalLocalization.GetString("AddEventWindow.ValidationError"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            KalendarzService kalendarzService = new KalendarzService();
            kalendarzService.AddWydarznie(new Wydarzenie(EventNameInput.Text, EventDescriptionInput.Text, StartDate, EndDate));

            MessageBox.Show(GlobalLocalization.GetString("AddEventWindow.Success"), GlobalLocalization.GetString("AddEventWindow.SuccessTitle"), MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
