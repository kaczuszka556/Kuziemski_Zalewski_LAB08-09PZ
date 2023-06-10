using GUI.Extensions;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class OptionsWindow : Form, IDisposable
    {
        private enum OptionType
        {
            Temp,
            Language
        }

        UserControl CurrentUserControl;
        PreferencjeService PreferencjeService;
        public OptionsWindow()
        {

            PreferencjeService = new PreferencjeService();

            UpdateLanguage();

            InitializeComponent();

            GlobalEventManager.OnLanguageChanged += UpdateLanguage;


        }

        private void UpdateLanguage()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture =
                new System.Globalization.CultureInfo(PreferencjeService.PobierzJezyk());
            System.Threading.Thread.CurrentThread.CurrentUICulture =
                new System.Globalization.CultureInfo(PreferencjeService.PobierzJezyk());

            List<TreeNode> allNodes = GetAllNodes(OptionsMenu.Nodes);

            ResourceManager resourceManager = Properties.Lang.ResourceManager;

            foreach (TreeNode item in allNodes)
            {
                item.Text = resourceManager.GetString("OptionsMenu." + item.Name) != null ? resourceManager.GetString("OptionsMenu." + item.Name) : "<<EMPTY>>";
            }
        }

        public void Dispose()
        {
            GlobalEventManager.OnLanguageChanged -= UpdateLanguage;

        }

        private List<TreeNode> GetAllNodes(TreeNodeCollection nodes)
        {
            List<TreeNode> allNodes = new List<TreeNode>();

            foreach (TreeNode node in nodes)
            {
                allNodes.Add(node);
                allNodes.AddRange(GetAllNodes(node.Nodes));
            }

            return allNodes;
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
