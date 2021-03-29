using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.Controllers
{
    class StudentControler
    {
        public static List<Student> GetListStudent(int _idClass)
        {
            return new List<Student>();
        }

        public static void StartInput()
        {
            Student student = new Student("Dinh Huynh Tien Phu", "19120325", 10);
            student.Add("KHTN", "CNTT", "19CTT2");
            Student student2 = new Student("Nguyen Anh Tuan", "19120416", 9);
            student2.Add("KHTN", "CNTT", "19CTT2");
            Student student3 = new Student("Doan Anh Khoi", "19120111", 5);
            student3.Add("KHTN", "CNTT", "19CTT3");
            Student student4 = new Student("Nguyen Thi Loan", "19120225", 10);
            student4.Add("UIT", "CNTT", "IT_01");
            Console.WriteLine("\n*********Khoi tao danh sach luc dau:***********\n");
        }


        public static void RemoveStudent(Student _student)
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
        public static void UpdateStudent(Student old_student)
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
