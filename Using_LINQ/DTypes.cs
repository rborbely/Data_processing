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

namespace Using_LINQ
{
    enum gender
    {
        Male,
        Female
    }

    class Person 
    {
        private int _age;
        private string _name;
        private string _job;
        private string _country;
        private bool _married;
        private gender _gender;
        private string _addr;

        public int Age { get => _age; set => _age = value; }
        public string Name { get => _name; set => _name = value; }
        public string Job { get => _job; set => _job = value; }
        public string Country { get => _country; set => _country = value; }
        public bool Married { get => _married; set => _married = value; }
        internal gender Gender { get => _gender; set => _gender = value; }
        public string Address { get; set; }

        public int Age2
        {
            get
            {
                return _age;
            }

            set
            {
                this._age = value;
            }
        }


        public Person(String name, int age, gender gender)
        {
            this._name = name;
            this._age = age;
            this._job = "";
            this._country = "Hungary";
            this._married = false;
            this._gender = gender;
            this._addr = "";
        }
    }

    
}
