using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using ConsoleApp4.Model;
using ConsoleApp4.Services;
using ConsoleApp4.Services.Interfaces;

namespace ConsoleApp4.Controllers
{
    internal class TeacherController
    {
        
        public void ExecuteCreate()
        {
            
            Console.WriteLine("FullName daxil edin");
            string fullName = Console.ReadLine();

            TeacherAge: Console.WriteLine("please enter the age");
            string age = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(age)) 
            {
                Console.WriteLine("Teacher age is required try again.");
                goto TeacherAge;
            }
            bool IsCoorectAgeFormat = int.TryParse(age, out int teacherAge);

            if (!IsCoorectAgeFormat)
            {
                Console.WriteLine("teacher age format is wrong, try again");
                goto TeacherAge;
            }
            Console.WriteLine("Please enter the email");
            string email = Console.ReadLine();


            Teacher teacher = new()
            {
                FullName = fullName,
                Age = teacherAge,
                Email = email
            };

            ITeacherService teacherService= new TeacherService();
            teacherService.Create(teacher);
            
        }

        public void Delete()
        {
            TeacherId: Console.WriteLine("enter id witch you want to delete:");
            string teacherId = Console.ReadLine();

            bool isCorrectTeacherId = int.TryParse(teacherId, out int deleteId);
            if (!isCorrectTeacherId)
            {
                Console.WriteLine("ID format is wrong , try again.");
                    goto TeacherId;
            }

            ITeacherService teacherService = new TeacherService();
            teacherService.Delete(deleteId);
            Console.WriteLine("success");

        }

        public void GetAll()
        {
            ITeacherService teacherService = new TeacherService();
            var teacher = teacherService.GetAll();

            foreach (var item in teacher)
            {
                Console.WriteLine($"{item.Id} {item.FullName} {item.Email}");
            }
        }
        
    }
}
