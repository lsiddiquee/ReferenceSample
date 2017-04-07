using StandardLibrary;
using System;

namespace FixedClassicConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMath lib = new MyMath();
            Console.WriteLine(lib.Add(5, 6));
        }
    }
}
