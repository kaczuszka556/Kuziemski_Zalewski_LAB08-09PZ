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
            InitializeComponent();

            List<Language> languages = new List<Language>
            {
                new Language("Polish", "pl-PL"),
                new Language("English", "en-EN")
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
