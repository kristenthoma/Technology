using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
    public class Computer : Technology
    {
        public string Password { get; set; }
        public Computer(int serialNumber, string name, string username, string password)
            : base(serialNumber, name, username)
        {
            this.Password = password; 
        }

        public void ShowPassword()
        {
            Console.WriteLine(Password);
        }

        public void id()
        {
            int i = 001;
            Console.WriteLine($"Computer id: {i++}");
        }
    }
}

