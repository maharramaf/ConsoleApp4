using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp4.Data;
using ConsoleApp4.Model;
using ConsoleApp4.Services.Interfaces;

namespace ConsoleApp4.Services
{
    internal class TeacherService: ITeacherService
    {
        public static int countID = 0;
        public void Create(Teacher teacher)
        {
            countID = teacher.Id;
            Array.Resize(ref AppDbContext.teachers, AppDbContext.teachers.Length + 1);
            AppDbContext.teachers[AppDbContext.teachers.Length - 1] = teacher;
            countID++;
        }

        public void Delete(int id)
        {
            AppDbContext.teachers.Where(m => m.Id != id).ToArray();
        }


        public Teacher[] GetAll()
        {
            return AppDbContext.teachers; 
        }
    }
}
 