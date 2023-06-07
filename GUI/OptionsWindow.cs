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
    public partial class OptionsWindow : Form
    {
        private enum OptionType
        {
            Temp,
            Language
        }

        UserControl CurrentUserControl;

        public OptionsWindow()
        {
            InitializeComponent();




        }

        private void OptionsWindow_Load(object sender, EventArgs e)
        {

        }

        private void OptionsMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selectedNode = e.Node;

            if (selectedNode != null && selectedNode.Tag != null)
            {
                switch ((OptionType)selectedNode.Tag)
                {
                    case OptionType.Temp:
                        DisplayOptionsUserControl(null);
                        break;

                    case OptionType.Language:
                        DisplayOptionsUserControl(languageOptions);
                        break;

                    default:
                        DisplayOptionsUserControl(null);
                        break;
                }
            }
        }

        private void DisplayOptionsUserControl(UserControl userControl)
        {
            CurrentUserControl?.Hide();
            CurrentUserControl = userControl;
            CurrentUserControl?.Show();
        }
    }


}
