/***************************************************************/
/* Author: Roland Borbély                                      */
/* Title:  Lambda_Exp_1                                        */
/*                                                             */
/* This is a simple example program to demonstrate my way of   */
/* design and implementation of using lambda expressions. This */
/* file is the main of the application                         */
/***************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;


namespace Lambda_Exp_1
{
       
    class Program
    {
        /* Create global variable */
        static List<Person> people = new List<Person>();

        static void Main(string[] args)
        {
            /* Fill up with some dummy data */
            people.Add(new Person("Tom", 33, gender.Male));
            people.Add(new Person("Nick", 28, gender.Male));
            people.Add(new Person("Jenny", 18, gender.Female));
            people.Add(new Person("Louise", 45, gender.Female));
            people.Add(new Person("Frank", 67, gender.Male));


            Console.WriteLine("Let's, list the ladies!");

            List<Person> ladies = people.FindAll(prs => prs.Gender == gender.Female);

            ladies.ForEach((prs) => Console.WriteLine("{0} is a {1} and is {2}.",
                                                     prs.Name,
                                                     prs.Gender,
                                                     prs.Age));

            Console.WriteLine("\nNow  list the men!");

            /* First find all the men...  */
            List<Person> men = people.FindAll(prs => prs.Gender == gender.Male);
            /* Write them on output */
            men.ForEach((prs) => Console.WriteLine("{0} is a {1} and is {2}.",
                                         prs.Name,
                                         prs.Gender,
                                         prs.Age));


            /*  Now the same with a shorter call */
            Console.WriteLine("\n... and again with a more simple form!");
            people.ForEach(prs =>
            {
                if (prs.Gender == gender.Male)
                {
                    Console.WriteLine("{0} is a {1} and is {2}.",
                                        prs.Name,
                                        prs.Gender,
                                        prs.Age);
                }

            });

            /* Added to prevent closing application. */
            Console.Read();
        }
    }
}
