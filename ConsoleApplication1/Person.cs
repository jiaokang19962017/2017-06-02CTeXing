using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }

        public Person()
        {
                
        }
        public Person(string name,int age,string sex)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = sex;
        }
    }
}
