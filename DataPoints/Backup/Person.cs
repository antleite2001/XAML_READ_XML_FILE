using System.Collections.Generic;

namespace DataBindingWPF
{
    public class Person
    {
        private int _id;
        private string _fullName;
        private string _title;
        private string _city;

        public Person(int id, string fullName, string title, string city)
        {
            _id = id;
            _fullName = fullName;
            _title = title;
            _city = city;
        }

        public string City
        {
            get { return _city; }
            set { _city = value; }
        } 
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        } 

        public string FullName
        {
            get { return _fullName; }
            set { _fullName = value; }
        } 
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        } 

    }
}