using Kuziemski_Zalewski_LAB08_09PZ_BK;

namespace GUI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.Text = "Kalendarz";

            LeftKalendarzWypiszDni(DateTime.Now.Month, DateTime.Now.Year);

        }
        private void LeftKalendarzTable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LeftKalendarzWypiszDni(int miesiac, int rok)
        {
            LeftMiesiacRokLabel.Text = new DateTime(rok, miesiac, 1).ToString("MMMM yyyy").ToUpper();

            int pierwszyDzien = Narzêdziowa.PierwszyDzieñ(miesiac, rok) - 1;
            int dni = Narzêdziowa.DniWMiesiacu(miesiac, rok);
            int licznikDzien = 0;

            for (int row = 0; row < LeftKalendarzTable.RowCount; row++)
            {
                if (licznikDzien == dni)
                    break;
                for (int column = pierwszyDzien; column < LeftKalendarzTable.ColumnCount; column++)
                {
                    if (licznikDzien == dni)
                        break;
                    Control control = LeftKalendarzTable.GetControlFromPosition(column, row);
                    if (control != null && control is Label label)
                    {
                        licznikDzien++;
                        label.Text = (licznikDzien).ToString();
                    }
                }

                pierwszyDzien = 0;
            }
        }
    }
}