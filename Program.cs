using System;
using System.Collections.Generic;
using System.Linq;

namespace HW_8._1
{
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public bool Diplom { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();
            var result = ran.Next(0, 2);
            bool finish = true;
            for (int i = 0; i < 2; i++)
            {
                if (result == 0)
                {
                    finish = false;
                }
                else
                {
                    finish = true;

                }
            }
            Stack<Student> student = new Stack<Student>();
            student.Push(new Student { Name = "Salli", Surname = "Erton", Diplom = finish });
            student.Push(new Student { Name = "Anna", Surname = "Terkina", Diplom = finish });
            student.Push(new Student { Name = "Anton", Surname = "Gnilov", Diplom = finish });
            student.Push(new Student { Name = "Sasha", Surname = "Ivanova", Diplom = finish });
            student.Push(new Student { Name = "Tom", Surname = "Poplan", Diplom = finish });



            for (int j = 0; j < 5; j++)
            {
                Student _student = student.Pop();
                if (_student.Diplom == true)
                {
                    Console.WriteLine($"{_student.Name} {_student.Surname} got coffe");
                }
                else
                {
                    Console.WriteLine($"{_student.Name} {_student.Surname}  didn't got coffe");
                }
            }
            Console.WriteLine();

        }
    }
}
