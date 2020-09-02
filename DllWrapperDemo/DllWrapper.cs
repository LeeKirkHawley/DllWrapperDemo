using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace DllWrapperDemo
{
    public class DllWrapper
    {
        [DllImport("Wrappee.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        static public extern int TestOne();

        [DllImport("Wrappee.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        static public extern int TestTwo();

        public int GetOne() {
            int i = DllWrapper.TestOne();
            return i;
        }

        public int GetTwo() { 
            int i = DllWrapper.TestTwo();
            return i;
        }
    }
}
