using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    public class Student
    {
        public string Surname;
        public string Name;
        public string Group;
        public int IdNumber;
        public DateTime Birthday;
        public bool Pay;

        public Student() { }
        public Student(string surname, string name)
        {
            Surname = surname;
            Name = name;
        }
        public Student(string surname, string name, string group, int idNumber, DateTime birthday,
            bool pay)
        {
            Surname = surname;
            Name = name;
            Group = group;
            IdNumber = idNumber;
            Birthday = birthday;
            Pay = pay;
        }

    }
}
