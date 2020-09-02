using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace DllWrapperDemo
{

    public class Class1
    {
        [DllImport("DllWrapperDemo.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern int TestFunc();


    }
}
