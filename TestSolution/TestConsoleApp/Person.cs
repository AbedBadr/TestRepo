using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsoleApp
{
    class Person
    {
        public enum Genders { Male, Female}

        public Genders Gender { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(Genders gender, int id, string name, int age)
        {
            Gender = gender;
            Id = id;
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"{nameof(Gender)}: {Gender}, {nameof(Id)}: {Id}, {nameof(Name)}: {Name}, {nameof(Age)}: {Age}";
        }
    }
}
