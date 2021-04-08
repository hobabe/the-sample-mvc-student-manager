using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.Controllers
{
    class StudentControler
    {
        public static List<StudentModel> GetListStudent(int _idClass)
        {
            return new List<StudentModel>();
        }


        public static void RemoveStudent(StudentModel _student)
        {
            string _universityname, _departmentname, _classname;

            //foreach (University university in Universities)
            //{
            //    _universityname = university.Name;
            //    foreach (Department department in university.Departments)
            //    {
            //        _departmentname = department.Name;
            //        foreach (Class @class in department.Classes)
            //        {
            //            _classname = @class.Name;
            //            @class.Students.Remove(_student);
            //        }
            //    }
            //}
        }
        public static void UpdateStudent(StudentModel old_student)
        {
            //foreach (University university in Universities)
            //{
            //    foreach (Department department in university.Departments)
            //    {
            //        foreach (Class @class in department.Classes)
            //        {
            //            /*if(*/
            //            @class.Students.Remove(old_student);//)Console.WriteLine("removed "+old_student.Name) ;
            //        }
            //    }
            //}
            //old_student = ViewInfo.Add(old_student.University, old_student.Department, old_student.Class_name, old_student);
            //CleanEmpty();
        }
    }
}
