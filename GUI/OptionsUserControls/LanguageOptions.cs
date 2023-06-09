using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.OptionsUserControls
{
    public partial class LanguageOptions : UserControl
    {
        public LanguageOptions()
        {
            // TODO: Zaciągać z bazy język i tu go ustawiać
            System.Threading.Thread.CurrentThread.CurrentCulture =
                new System.Globalization.CultureInfo("pl");
            System.Threading.Thread.CurrentThread.CurrentUICulture =
                new System.Globalization.CultureInfo("pl");
            InitializeComponent();

            List<Language> languages = new List<Language>
            {
                new Language("Polski", "pl"),
                new Language("English", "en")
            };

            LanguageSelect.DataSource = languages;
            LanguageSelect.DisplayMember = "Name";
            LanguageSelect.SelectedIndex = 0;
            LanguageSelect.ValueMember = "Code";
        }

       
    }

    public class Language
    {
        public string Name { get; set; }
        public string Code { get; set; }

        public Language(string name, string code)
        {
            Name = name;
            Code = code;
        }
    }
}
