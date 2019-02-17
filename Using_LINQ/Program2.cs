using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Using_LINQ
{
    class Program2
    {

        /* Create global variable */
        static List<Person> people = new List<Person>();  
        

        #region main program
        static void Main(string[] args)
        {

            /* Fill up with some dummy data */
            people.Add(new Person("Tom", 33, gender.Male));
            people.Add(new Person("Nick", 28, gender.Male));
            people.Add(new Person("Jenny", 18, gender.Female));
            people.Add(new Person("Louise", 45, gender.Female));
            people.Add(new Person("Frank", 67, gender.Male));
            people[2].Address = "Veszprém";

            var person = from c in people
                         where c.Age > 30
                         select c;

            SimpleArrayQuery();
            

        }
        #endregion



        static public void SimpleArrayQuery()
        {
            String[] things = { "table", "chair", "carpet", "new scissor", "white window",
                                "red car", "blackhole", "R2D2"};


            var oneword = from thing in things
                          where !thing.Contains(" ")
                          select thing;

            foreach (var t in oneword)
            {
                Console.WriteLine(t);
            }

        }
    }
}
