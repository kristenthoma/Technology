using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
    public class Technology
    {
        public static int SerialNumber { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }


        public Technology(int serialNumber, string name, string username)
        {
            SerialNumber = serialNumber;
            this.Name = name;
            this.Username = username;
        }

        public void GetTechInfo()
        {
            Console.WriteLine($"Serial number: {SerialNumber} | Name: {this.Name} | Username: {this.Username}");
        }

        public void AddToUsername()
        {
            this.Username += 1;
            Console.WriteLine(this.Username);
        }
    }
}
