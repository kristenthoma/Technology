using System;

namespace Technology
{
    class Program
    {
        static void Main(string[] args)
        {
            SmartPhone phone1 = new SmartPhone(123, "Kristen's Phone", "kristenthoma", "iPhone");
            SmartPhone phone2 = new SmartPhone(101, "Patricks Phone", "patrickkincaid", "iphone");
            phone1.GetTechInfo();
            phone1.BrandOfPhone();
            phone1.id();
            phone2.id();

            //Console.WriteLine("------------------");

            //Laptop laptop1 = new Laptop(456, "Kristens Laptop", "kthoma91", "Windows");
            //laptop1.GetTechInfo();
            //laptop1.WhatOSAreWeUsing();
            //laptop1.id();

            //Console.WriteLine("------------------");

            //Computer computer1 = new Computer(789, "Kristens Computer", "kmthoma", "p@ssW0rD");
            //computer1.GetTechInfo();
            //computer1.ShowPassword();
            //computer1.id();


        }
    }
}
