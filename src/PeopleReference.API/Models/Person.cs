using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleReference.API.Models
{
    public class Person
    {
        public string Name { get; set; }
        public int Id { get; set; }
        static int id;
        public Person(string name)
        {
            Name = name;
            Id = id++;
        }
    }
}
