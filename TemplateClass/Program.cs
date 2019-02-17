using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateClass
{
    class Program
    {
        static void Main(string[] args)
        {
            NewType<Person> female = new NewType<Person>( new Female { Name = "Emilie", Age = 34 });
            NewType<Person> male = new NewType<Person>( new Male { Name = "Jack", Age = 56 });


            Console.WriteLine( female.ToString());
            Console.WriteLine(male.ToString());


            Console.ReadKey();
        }
    }

    class Person
    {
        public string Name;
        public int Age;
    }

    class Male : Person
    {
        public readonly String Gender = "Male";
    }

    class Female : Person
    {
        public readonly string Gender = "Male";
    }

    class NewType<T> where T : Person
    {
        private object _value;


        public NewType(T value)
        {
                _value = value;
        }

        public override String ToString()
        {
            return ((Person)_value).Name + " is " + ((Person)_value).Age + " years old.";
        }

    }
}
