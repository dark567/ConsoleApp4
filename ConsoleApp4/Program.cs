﻿using System;

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
            var attributes = type.GetCustomAttributes(false);

            foreach (var attribute in attributes)
            {
                Console.WriteLine(attribute);
            }

            var properties = type.GetProperties();

            foreach (var prop in properties)
            {
                Console.WriteLine(prop.PropertyType.Name +" "+ prop.Name);
            }

            Console.ReadLine();
        }
    }
}
