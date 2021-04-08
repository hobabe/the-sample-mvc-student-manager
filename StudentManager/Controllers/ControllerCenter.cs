using StudentManager.Blo;
using StudentManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.Controllers
{
    class ControllerCenter
    {
        static string optionSelect = "";
        static DataContext _dataContext;
        static IStudentManagerment _studentManagerment;

        static List<UniversityModel> Universities { set; get; }
        public ControllerCenter()
        {
            InitComponent();
        }

        public static void InitComponent()
        {
            _studentManagerment = new StudentManagerment();
        }

        public void InfoManagerment()
        {
            Console.WriteLine("Type to select:" + GenerateInfoBoard());

            optionSelect = Console.ReadLine();

            switch (optionSelect)
            {
                case "1"://add new
                    if (_dataContext == null)
                    {
                        _dataContext = new DataContext();
                    }

                    StudentModel studentModel = AddNewStudent();
                    var de = new DepartmentModel();
                    var cls = new ClassModel();

                    cls._students = new List<StudentModel>();
                    cls._students.Add(studentModel);

                    de._classes = new List<ClassModel>();
                    de._classes.Add(cls);

                    _dataContext.
                        UniversityModel.
                        _departmentModels.Add(de);

                        ObjectInOut.Save(_dataContext);
                    break;
                case "2"://update 
                    break;
                case "5"://update 
                    break;
                default:
                    return;
            }

            Console.Clear();
            InfoManagerment();
        }

        private string GenerateInfoBoard()
        {
            List<string> actions = new List<string>()
            {
                "add new",
                "update",
                "exist",
                "show sv",
                ">Read data",
                ">Save data",
            };

            int i= 1;
            string textInfoAll = string.Empty;
            foreach(var action in actions)
            {
                textInfoAll += string.Format("\n{0} -> {1}", i++, action);
            }

            return textInfoAll +"\n -------------------- \n";
        }


        #region ADD INFO
        public static StudentModel AddNewStudent()
        {
            StudentModel studentModel = new StudentModel();

            studentModel.Name = InfoInput("Ten");
            studentModel.Age = InfoInput("Tuoi");
            studentModel.ID = InfoInput("Id");

            return studentModel;
        }

        private static string InfoInput(string field)
        {
            Console.WriteLine("Xin nhap "+ field);
            return Console.ReadLine();
        }

        private static void AddNewStudent(StudentModel studentModel)
        {
            _studentManagerment.Save(studentModel);

            ViewInfo.NotificationSuccess(studentModel.Name);
        }


        #endregion

        #region SHOW INFO

        #endregion

        public static List<StudentModel> ShowAllStudentByClassId(StudentModel studentModel)
        {
            //var listStudent = StudentControler.GetListStudent(id);

            //foreach(var s in listStudent)
            //{
            //    s.Class_name += " [Add thanh cong]" + studentModel.name;
            //}

            return null;
        }

    }
}
