using System.Collections.Generic;

namespace DataBindingWPF
{
  internal class PersonService
  {


    public List<Person> GetPersonList()
    {
      List<Person> personList = new List<Person>
      {
        new Person(1, "Elizabeth Brown", "Sales Representative", "London"),
        new Person(3, "Thomas Hardy", "Sales Representative", "London"),
        new Person(4, "Yang Wang", "Sales Representative", "Bern"),
        new Person(2, "Maria Anders", "Owner", "Berlin")
      };
      return personList;
    }

  }
}
