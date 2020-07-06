using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace varStep230
{
    public class Person
    {
        

        public  string firstName {get; set;}
        public string lastName { get; set; }
        public IEnumerable<Person> Children { get;}


        public Person()
        {
            Children = new List<Person>();
        }
        public Person(string firstName)
            : this()
        {
            this.firstName = firstName;
        }
        public Person(string firstName,string lastName)
            : this(firstName)
        {
            this.lastName = lastName;
        }

        
    }
}
