using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp4.Model;

namespace ConsoleApp4.Services.Interfaces
{
    internal interface ITeacherService
    {
        public void Create(Teacher teacher);
        public void Delete(int id);
        public Teacher[] GetAll();
    }
}
