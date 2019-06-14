using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Drawing;

namespace KonnettoreBitss
{
    public class KonnettoreVuCiEffe
    {
        public object ImportObject(object obj)
        {
            if (IsValid(obj))
                return obj;
            else
            {
                ((IDisposable)obj).Dispose();
                return null;
            }
        }
        public bool IsValid(object obj)
        {
            if ((Color)obj == Color.Black)
                return false;
            else
                return true;
        }
    }
}
