using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technology
{
    class SmartPhone : Technology
    {
        public string TypeOfPhone { get; set; }
        public SmartPhone(int serialNumber, string name, string username, string typeOfPhone)
            : base(serialNumber, name, username)
        {
            this.TypeOfPhone = typeOfPhone;
        }

        public void BrandOfPhone()
        {
            Console.WriteLine(TypeOfPhone);
        }

        public void id()
        {
            int i = 001;
            Console.WriteLine($"Smartphone id: {i++}");
        }
    }
}

