using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person
    {
        private string name;
        private Nullable<int> age;

        public string Name
        {
            get { return this.name; }
            set
            {
                if (this.name == null)
                {
                    throw new ArgumentNullException("Numele nu poate fi null");
                }

                else
                {
                    this.name = value;
                }
            }
        }

        public Nullable<int> Age
        {
            get { return this.age; }
            set
            {
                if (age <= 0)
                {
                    throw new ArgumentOutOfRangeException("Varsta nu poate fi negativa");
                }
            }
        }

        public Person(string name, Nullable<int> age)
        {
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("Name: " + this.name);
            if (this.age == null)
            {
                stringBuilder.AppendLine("Age: null");
            }
            else
            {
                stringBuilder.AppendLine("Age: " + this.age);
            }
            return stringBuilder.ToString();
        }
    }
}
