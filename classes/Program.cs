using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class Program
    {
       static List<Student> students = new List<Student>();
        static void Main(string[] args)
        {
            bool flag = false;
            while (!flag)
            {
                Console.WriteLine("Хотите добавить нового студента? 1 - да, 2 - нет");
                if (Console.ReadLine() == "1")
                    AddStudent();
                else
                    flag = true;
            }

            Console.ReadLine();
        }
        private static void AddStudent()
        {
            Student student;
            Console.WriteLine("Введите фамилию студента");
            string surname = Console.ReadLine();
            Console.WriteLine("Введите имя студента");
            string name = Console.ReadLine();
            Console.WriteLine("Введите номер группы");
            string group = Console.ReadLine();
            DateTime birthday = new DateTime();
            bool flag = false;
            while (!flag)
            {
                Console.WriteLine("Введите дату рождения");
                flag = DateTime.TryParse(Console.ReadLine(), out birthday);
            }
            int idNumber = 0;
            flag = false;
            while (!flag)
            {
                Console.WriteLine("Введите номер студенческого билета");
                flag = int.TryParse(Console.ReadLine(), out idNumber);
            }
            bool pay;
            Console.WriteLine("Форма обучения: 1 - бюджет, 2 - коммерческая основа");
            if (Console.ReadLine() == "1")
            {
                pay = false;
            }
            else
                pay = true;
            student = new Student(surname, name, group, idNumber, birthday, pay);
            students.Add(student);
            Console.WriteLine(string.Format("Имя студента {0} {1}, группа {2}, номер студенческого {3}, день рождения {4}",
                student.Surname, student.Name, student.Group, student.IdNumber, student.Birthday.ToShortDateString()));
            Console.WriteLine("Текущее число студентов:" + students.Count);
        }
    }
}
