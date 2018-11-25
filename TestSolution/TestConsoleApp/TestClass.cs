using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsoleApp
{
    class TestClass
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public TestClass(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}";
        }
    }
}
