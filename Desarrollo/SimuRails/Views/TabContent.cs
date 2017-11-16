using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuRails.Views
{
    public interface TabContent
    {
        void onTabEnter(object sender, EventArgs args);
    }
}
