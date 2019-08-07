using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FxP
{
    class customcolumn : System.Windows.Forms.DataGridViewLinkColumn
    {
        public Dictionary<int, string> urls = new Dictionary<int, string>();
    }
}
