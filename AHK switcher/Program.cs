using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHK_switcher
{
    class Program
    {
        [STAThread]
        public static void Main()
        {
            AHKSwitcher1 ahkswitcher = new AHKSwitcher1();
            ahkswitcher.ShowDialog();
        }
    }
}
