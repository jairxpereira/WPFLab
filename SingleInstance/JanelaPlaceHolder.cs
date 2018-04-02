using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleInstance
{
    class JanelaPlaceHolder
    {
        public System.Windows.Window wnd;

        public JanelaPlaceHolder()
        {
            wnd = null;
        }

        public JanelaPlaceHolder(System.Windows.Window _wnd)
        {
            wnd = _wnd;
        }

        public override string ToString()
        {
            if (wnd == null) return "null";
            return wnd.Title;
        }
    }
}
