using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_2023.Models
{
    public class    Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Age { get; set; }

        public Customer(int id, string name, string address, string age)
        {
            Id = id;
            Name = name;
            Address = address;
            Age = age;
        }
    }
}