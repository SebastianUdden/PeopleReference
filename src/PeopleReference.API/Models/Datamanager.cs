using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleReference.API.Models
{
    public class Datamanager
    {
        List<Person> people;
        public Datamanager()
        {
            //people.Clear();
            people = new List<Person>();

            #region Addpeople
            people.Add(new Person("Bob"));
            people.Add(new Person("John"));
            people.Add(new Person("Lisa"));
            people.Add(new Person("Ann"));
            people.Add(new Person("Graham"));
            people.Add(new Person("Sara"));
            people.Add(new Person("Leif"));
            people.Add(new Person("Bertil"));
            people.Add(new Person("Victor"));
            people.Add(new Person("Harald"));
            #endregion
        }
        public Person[] GetAllPeople()
        {
            var peopleArray = new Person[10];

            for (int i = 0; i < people.Count; i++)
            {
                peopleArray[i] = people[i];
            }
           
            return peopleArray;
        }

        public Person GetById(int id)
        {
            var person = people.Find(p => p.Id == id);
            return person;
        }
    }
}
