using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elephant
{
    class Elephant
    {
        public string Name;
        public int EarSize;
        public void WhoAmI()
        {
            MessageBox.Show("Moje uszy maja" + EarSize + " cm szerokosci",
                Name + " mowi...");
        }
    }
}
