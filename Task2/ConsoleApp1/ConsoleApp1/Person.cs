using System.Globalization;
using System;

namespace ConsoleApp1
{
    internal class Person
    {
        private string _fullName;
        private sbyte _age;
        private int _phoneNumber;


        public Person(string fullName, sbyte age, int phoneNumber)
        {
            FullName = fullName;
            Age = age;
            PhoneNumber = phoneNumber;

        }

        public string FullName
        {
            get
            {
                return _fullName;
            }
            set
            {
               

                var words = value.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (words.Length >= 2 )
                {
                    _fullName = value;
                    
                }

            }
        }
        public sbyte Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }
        public int PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
               _phoneNumber = value;
            }
        }

    }
}
