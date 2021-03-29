using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    class Class: Department
    {
        private string _name;
        public string Name { get => _name; set => _name = value; }
        private int _standardBestScore = 8;
        private List<Student> students = new List<Student>();
        internal List<Student> Students { get => students; set => students = value; }

        public List<Student> GetTop10Student()
        {
            /// name
            List<Student> list = new List<Student>();
            foreach(var s in students)
            {
                if(s._score> 8)
                {
                    list.Add(s);
                }
            }
            return list;
        }
    }
}
