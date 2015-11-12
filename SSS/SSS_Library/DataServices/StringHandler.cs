using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSS_Library.DataServices
{
    public class StringHandler
    {
        public static bool CheckIfStringANumber(string str)
        {
            int i;
            return int.TryParse(str, out i);
        }
    }
}
