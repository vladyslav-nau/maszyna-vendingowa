using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt1_VladyslavNaumenko51447
{
    class vnItemSystem
    {
        public struct vnItemType
        {
            public string vnItemName { get ; set; }
            public double vnItemValue { get ;set ; }
            public vnItemType(string iName, double iValue)
            {
                vnItemName = iName;
                vnItemValue = iValue;
            }
        }

        public static vnItemType vnItem1 = new vnItemType("Fanta", 5.0);
        public static vnItemType vnItem2 = new vnItemType("Coca-Cola", 5.7);
        public static vnItemType vnItem3 = new vnItemType("Sprite", 3.3);
        public static vnItemType vnItem4 = new vnItemType("Snikers", 2.5);
        public static vnItemType vnItem5 = new vnItemType("Twix", 2.0);
        public static vnItemType vnItem6 = new vnItemType("Milkiway", 2.25);
        public static vnItemType vnItem7 = new vnItemType("ZOLOTYSTI", 100);
    }
}
