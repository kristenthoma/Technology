using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
    class Laptop : Technology
    {
        public string OperatingSystem { get; set; }
        public Laptop (int serialNumber, string name, string username, string operatingSystem)
            : base(serialNumber, name, username)
        {
            this.OperatingSystem = operatingSystem;
        }

        public void WhatOSAreWeUsing()
        {
            Console.WriteLine(OperatingSystem);
        }

        public void id()
        {
            int i = 001;
            Console.WriteLine($"Laptop id: {i++}");
        }
    }
}
