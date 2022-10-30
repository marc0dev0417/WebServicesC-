using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServices
{
    internal class Person
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public Address address{ get; set; }
    }

    partial class Animal
    {
        public string id;
    }
    partial class Animal
    {
        public string name;
    }
    partial class Animal
    {
        public string age;
    }
}


