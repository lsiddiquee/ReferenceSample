using StandardLibrary;
using System;

namespace ClassicConsoleApp
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
