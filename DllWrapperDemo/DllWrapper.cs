using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace DllWrapperDemo
{
    //public class ManagedData {
    //    public string Text { get; set; }
    //    public int BigValue { get; set; }
    //}

    public class DllWrapper
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct ManagedData {
            [MarshalAs(UnmanagedType.BStr, SizeConst = 50)]
            public string Text;

            //[MarshalAs(UnmanagedType.I4)]
            public int BigValue;

        }

        [DllImport("Wrappee.dll", CharSet = CharSet.Unicode, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        static public extern int TestOne();

        [DllImport("Wrappee.dll", CharSet = CharSet.Unicode, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        static public extern int TestTwo();

        [DllImport("Wrappee.dll", CharSet = CharSet.Unicode, SetLastError = true, CallingConvention = CallingConvention.Cdecl)]
        static public extern void TestThree(out ManagedData data);


        public int GetOne() {
            int i = DllWrapper.TestOne();
            return i;
        }

        public int GetTwo() { 
            int i = DllWrapper.TestTwo();
            return i;
        }

        public void GetThree(out ManagedData managedData) {

            ManagedData data = new ManagedData();
            try {
                DllWrapper.TestThree(out data);
            }
            catch(Exception e) {

            }

            managedData = data;
        }
    }
}
