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
        private static List<UniversityModel> universities = new List<UniversityModel>();

        internal static List<UniversityModel> Universities { get => universities; set => universities = value; }

        public static void StartingUI() {
            DepartmentModel department = new DepartmentModel();
            SuperDeparment superDepartment = new SuperDeparment();


            Console.ReadKey();
        }

        public static void Add()
        {
            Console.WriteLine("Starting add new sinh vien");
        }

        public static string NotificationSuccess(string name)
        {
            return "Add thanh cong sv:" + name;
        }

        public static void ShowAllStudent(int idUniversity)
        {
            var list = ControllerCenter.ShowAllStudentByClassId(null);
            foreach(var s in list)
            {
                ShowCommon(s);

            }
        }

        private static void ShowCommon(StudentModel student)
        {
        }

    }
}
