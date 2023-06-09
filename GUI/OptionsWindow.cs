﻿using System;
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

            // TODO: Zaciągać z bazy język i tu go ustawiać
            System.Threading.Thread.CurrentThread.CurrentCulture =
                new System.Globalization.CultureInfo("pl");
            System.Threading.Thread.CurrentThread.CurrentUICulture =
                new System.Globalization.CultureInfo("pl");
            InitializeComponent();
            List<TreeNode> allNodes = GetAllNodes(OptionsMenu.Nodes);

            ResourceManager resourceManager = Properties.Lang.ResourceManager;

            foreach (TreeNode item in allNodes)
            {
                
                // TODO: Dodać tłumaczenia dla opcji do globalnego resource file np. OptionsMenu.nazwa_node
                item.Text = resourceManager.GetString("OptionsMenu."+item.Name) != null ? resourceManager.GetString("OptionsMenu." + item.Name) : "<<EMPTY>>";
            }


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