using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pac_man_proje
{
    class Input
    {

        /// <summary>
        /// mevcut klavye tuşlarının listesini yüklüyor.
        /// </summary>
        private static Hashtable keyTable = new Hashtable();

        public static void ChangeState(Keys key, bool state)
        {
            keyTable[key] = state;
        }
    }
}
