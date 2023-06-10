using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    internal static class GlobalEventManager
    {

        public delegate void LanguageChange();
        public delegate void EventCalendarChanged();

        public static event LanguageChange OnLanguageChanged;
        public static event EventCalendarChanged OnEventCalendarChanged;

        public static void TriggerOnLanguageChanged()
        {
            OnLanguageChanged?.Invoke();
        }

        public static void TriggerOnEventCalendarChanged()
        {
            OnEventCalendarChanged?.Invoke();
        }

    }
}
