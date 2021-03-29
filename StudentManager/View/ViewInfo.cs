using StudentManager.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    class ViewInfo
    {
        private static List<University> universities = new List<University>();

        internal static List<University> Universities { get => universities; set => universities = value; }

        public static void StartingUI() {
            Department department = new Department();
            SuperDeparment superDepartment = new SuperDeparment();

            department.TryAbstract(2018);
            superDepartment.TryAbstract(2018);

            Console.ReadKey();
        }

        public static void AddNew()
        {
            ControllerCenter.AddNewStudent();

        }

        public static void ShowAllStudent(int idUniversity)
        {
            var list = ControllerCenter.ShowAllStudentByClassId(idUniversity);
            foreach(var s in list)
            {
                ShowCommon(s);

                //show top 10|| kinh doanh, 
                s.GetTop10Student();
                s.GetTop10Depament();
            }
        }

        private static void ShowCommon(Student student)
        {
            Console.WriteLine("      #" + student.Name + " " + student.ID1 + " " + student.Score);
        }
    }
}
