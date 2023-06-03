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
            this.Text = "Add new Event";
            this.TopMost = true;
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(EventNameInput.Text) || string.IsNullOrWhiteSpace(EventDescriptionInput.Text)){
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Succesfully added!.", "Validation Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            KalendarzService kalendarzService = new KalendarzService();

            kalendarzService.AddWydarznie(new Wydarzenie(EventNameInput.Text, EventDescriptionInput.Text, DateTime.Now, DateTime.Now.AddMinutes(120)));

            this.Close();
        }
    }
}
