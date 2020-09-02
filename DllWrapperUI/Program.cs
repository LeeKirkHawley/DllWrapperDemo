using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DllWrapperDemo;

namespace DllWrapperUI {
    class Program {
        static void Main(string[] args) {

            DllWrapper wrapper = new DllWrapper();

            int testOneResult = wrapper.GetOne();
            Console.WriteLine($"GetOne() returned {testOneResult}");

            int testTwoResult = wrapper.GetTwo();
            Console.WriteLine($"GetTwo() returned {testTwoResult}");

            Console.Read();
        }
    }
}
