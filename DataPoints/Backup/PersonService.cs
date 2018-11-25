using System.Collections.Generic;

namespace DataBindingWPF
{
    class PersonService
    {
        public List<Person> GetPersonList()
        {
            Person elizabeth = new Person(1, "Elizabeth Brown", "Sales Representative", "London");
            Person maria = new Person(2, "Maria Anders", "Owner", "Berlin");
            Person thomas = new Person(3, "Thomas Hardy", "Sales Representative", "London");
            Person yang = new Person(4, "Yang Wang", "Sales Representative", "Bern");
            List<Person> personList = new List<Person>();
            personList.Add(elizabeth);
            personList.Add(maria);
            personList.Add(thomas);
            personList.Add(yang);
            return personList;
        }

    }
}
