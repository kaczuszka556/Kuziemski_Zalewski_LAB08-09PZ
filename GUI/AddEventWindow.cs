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
    public partial class AddEventWindow : Form
    {
        public AddEventWindow()
        {
            // TODO: Zaciągać z bazy język i tu go ustawiać
            System.Threading.Thread.CurrentThread.CurrentCulture =
                new System.Globalization.CultureInfo("pl");
            System.Threading.Thread.CurrentThread.CurrentUICulture =
                new System.Globalization.CultureInfo("pl");
            this.TopMost = true;
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(EventNameInput.Text) || string.IsNullOrWhiteSpace(EventDescriptionInput.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            DateTime StartDate = StartDatePicker.Value.Date;
            StartDate = StartDate.Date.Add(StartTimePicker.Value.TimeOfDay);
            DateTime EndDate = EndDatePicker.Value.Date;
            EndDate = EndDate.Date.Add(EndTimePicker.Value.TimeOfDay);

            if (EndDate < StartDate)
            {
                MessageBox.Show("End date can't be before start date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            KalendarzService kalendarzService = new KalendarzService();
            kalendarzService.AddWydarznie(new Wydarzenie(EventNameInput.Text, EventDescriptionInput.Text, StartDate, EndDate));

            MessageBox.Show("Event added succesfully!", "Event added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
