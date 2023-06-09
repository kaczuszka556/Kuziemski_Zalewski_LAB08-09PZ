using Kuziemski_Zalewski_LAB08_09PZ_BK;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.OptionsUserControls
{
    public partial class LanguageOptions : UserControl
    {
        PreferencjeService PreferencjeService;
        public LanguageOptions()
        {
            PreferencjeService = new PreferencjeService();

            System.Threading.Thread.CurrentThread.CurrentCulture =
                new System.Globalization.CultureInfo(PreferencjeService.PobierzJezyk());
            System.Threading.Thread.CurrentThread.CurrentUICulture =
                new System.Globalization.CultureInfo(PreferencjeService.PobierzJezyk());

            InitializeComponent();

            List<Language> languages = new List<Language>
            {
                new Language("Polski", "pl"),
                new Language("English", "en")
            };
            int index = languages.IndexOf(languages.Where(l => l.Code == PreferencjeService.PobierzJezyk()).First());
            LanguageSelect.DataSource = languages;
            LanguageSelect.DisplayMember = "Name";
            LanguageSelect.SelectedIndex = index;
            LanguageSelect.ValueMember = "Code";
        }

        private void LanguageSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            Language language = LanguageSelect.SelectedItem as Language;
            PreferencjeService.UstawJezyk(language.Code);
            
            // TODO: Aktualizacja tekstów na nowe tłumaczenie od razu po zmianie języka
            //System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LanguageOptions));
            //resources.ApplyResources(LanguageSelectLabel, "LanguageSelectLabel");
            //Invalidate();
            //Update();


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
