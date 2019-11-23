using System;

namespace CourseApp
{
    public class Person
    {
        private int age;

        public Person()
        : this(0, "Somename", "Somesurname", true)
        {
        }

        public Person(int age, string name, string surname, bool isMale)
        {
            Name = name;
            Surname = surname;
            Age = age;
            IsMale = isMale;
        }

        public string Name { get; set; }

        public string Surname { get; set; }

        public bool IsMale { get; set; }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value >= 0 && value < 20)
                {
                    this.age = value;
                }
                else
                {
                    Console.WriteLine("Age should be > 0 and < than 20");
                }
            }
        }

        public string View()
        {
            return @"hello";
        }
    }
}