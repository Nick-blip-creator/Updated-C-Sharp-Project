using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> nameList = new List<Employee>();
            //List<Employee> newNameList = new List<Employee>();

            nameList.Add(new Employee() { firstName = "Joe", lastName = "Johnson", ID = 13 });
            nameList.Add(new Employee() { firstName = "Mike", lastName = "Walker", ID = 2});
            nameList.Add(new Employee() { firstName = "Phil", lastName = "Speedo", ID = 4 });
            nameList.Add(new Employee() { firstName = "Maxelle", lastName = "Dancer", ID = 123 });
            nameList.Add(new Employee() { firstName = "Joe", lastName = "Rangr", ID = 1 });
            nameList.Add(new Employee() { firstName = "Tony", lastName = "Shooter", ID = 14 });
            nameList.Add(new Employee() { firstName = "Dai", lastName = "Alpha", ID = 19 });
            nameList.Add(new Employee() { firstName = "Crottoer", lastName = "Bravo", ID = 20 });
            nameList.Add(new Employee() { firstName = "Mark", lastName = "Dandy", ID = 39 });

            //foreach (Employee name in nameList)
            //{
            //    if (name.firstName == "Joe")
            //    {
            //        newNameList.Add(name);
            //    }
            //    Console.WriteLine(name.firstName);

            //}

            List<Employee> newNameList = nameList.Where(x => x.firstName == "Joe").ToList();
            List<Employee> newIDlist = nameList.Where(x => x.ID > 5).ToList();


            foreach (Employee name in newNameList)
            {
                Console.WriteLine(name.firstName);
            }

            foreach (Employee employeeID in newIDlist)
            {
                Console.WriteLine(employeeID.ID);
            }



            Console.Read();
          }
       }
    }

