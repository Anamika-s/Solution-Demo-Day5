using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    struct Address
    {
        string houseNo, streetName, city, state, zipCode;
        public void GetAdress()
        {
            Console.WriteLine("Enter House No");
            houseNo = Console.ReadLine();
        }

    }
    internal class Employee
    {
        int id;
        string name;
        Address address;
        string dept;
        public void Get()
        {
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
            address.GetAdress();
        }
    }
}
