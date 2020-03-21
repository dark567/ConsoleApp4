using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            var photo = new Photo("hello.png")
            {
                Path = @"C:\hello.png"
            };
            var type = typeof(Photo);
        }
    }
}
