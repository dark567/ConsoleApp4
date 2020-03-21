using System;
using System.Linq;

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
            var attributes = type.GetCustomAttributes(false); //false отключает отображение наследников

            foreach (var attribute in attributes)
            {
                Console.WriteLine(attribute);
            }

            var properties = type.GetProperties();

            foreach (var prop in properties)
            {
                var attrs = prop.GetCustomAttributes(false);
                if (attrs.Any(a => a.GetType() == typeof(GeoAttribute)))
                {
                    Console.WriteLine(prop.PropertyType.Name + " " + prop.Name);
                }


                //foreach (var attr in attrs)
                //{
                //    Console.WriteLine(attr);
                //}
            }

            Console.ReadLine();
        }
    }
}
