using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Bullock
{
    enum DesktopMaterial
    {
        Oak,
        Laminate,
        Pine,
        Rosewood,
        Veneer
    }
    internal class Desk
    {   
        // maximum and minimum constraints set as constants.
        public const int minWidth = 24;
        public const int maxWidth = 96;

        public const int minDebth = 12;
        public const int maxDebth = 48;
    }
}
