using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Extensions
{
    internal static class ControlExtension
    {
        public static IEnumerable<Control> GetAllControls(this Control control)
        {
            var controls = new List<Control>();
            GetAllControlsRecursive(control, controls);
            return controls;
        }

        private static void GetAllControlsRecursive(Control control, List<Control> controlList)
        {
            foreach (Control childControl in control.Controls)
            {
                controlList.Add(childControl);
                GetAllControlsRecursive(childControl, controlList);
                // TODO: Dodać dodawanie itemów z górnego menu do listy
            }
            
        }
    }
}
