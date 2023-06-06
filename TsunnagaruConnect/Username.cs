using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TsunnagaruConnect
{
    internal class Username
    {
        static string UName;
        public static string uname
        { 
            get { return UName; }
            set { UName = value; }
        }
    }
}
