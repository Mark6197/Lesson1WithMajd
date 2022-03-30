using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    public class Person
    {
        private int age;
        public int Age
        {
            get { return age; }
            set 
            { 
               age = value;
            }
        }

        //private string name;
        //public string Name
        //{
        //    get { return name; }
        //    set { name = value; }
        //}

        public Person()
        {
            this.Name = "Majd";    
        }

        public string Name { get; set; }

        //public void SetAge(int age)
        //{
        //    if (age>0)
        //    {
        //        this.age = age;
        //    }
        //}
        //public int GetAge()
        //{
        //    return age;
        //}
    }
}
