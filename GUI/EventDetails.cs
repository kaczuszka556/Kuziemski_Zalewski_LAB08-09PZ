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

        public EventDetails(Wydarzenie wydarzenie)
        {
            // TODO: Dodać ustawianie kultury pobranej z bazy
            InitializeComponent();

            Wydarzenie = wydarzenie;
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
