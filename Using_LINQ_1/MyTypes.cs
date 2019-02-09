/***************************************************************/
/* Author: Roland Borbély                                      */
/* Assembly:  Lambda_Exp_1                                     */
/* File: MyTypes.cs                                            */
/*                                                             */
/* This file contains type definitions in relation to this     */
/* application.                                                */
/***************************************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Exp_1
{
    enum gender
    {
        Male,
        Female
    }

    class Person 
    {
        private int age;
        private string name;
        private string job;
        private string country;
        private bool married;
        private gender gender;

        public int Age { get => age; set => age = value; }
        public string Name { get => name; set => name = value; }
        public string Job { get => job; set => job = value; }
        public string Country { get => country; set => country = value; }
        public bool Married { get => married; set => married = value; }
        internal gender Gender { get => gender; set => gender = value; }

        public int Age2
        {
            get
            {
                return age;
            }

            set
            {
                this.age = value;
            }
        }

        public Person(String name, int age, gender gender)
        {
            this.name = name;
            this.age = age;
            this.job = "";
            this.country = "Hungary";
            this.married = false;
            this.gender = gender;
        }
    }

    
}
