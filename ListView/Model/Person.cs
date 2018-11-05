using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListView.Model
{
    class Person
    {
        private int _id;
        private int _age;
        private string _name;

        public Person(int id, int age, string name)
        {
            _id = id;
            _age = age;
            _name = name;
        }

        public int Id
        {
            get { return _id;}
            set { _id = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


    }
}
