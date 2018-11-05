using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListView.Model;

namespace ListView.ViewModel
{
    class PersonVm
    {
        public List<Person> ListPerson { get; set; }

        public PersonVm()
        {
            ListPerson = new List<Person>()
            {
                new Person(123, 21 , "Zuhair"),
                new Person(123, 45 , "Petro"),
                new Person(123, 56 , "Lako")

            };
        }

    }
}
