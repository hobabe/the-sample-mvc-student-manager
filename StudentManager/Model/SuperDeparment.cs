using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    class SuperDeparment : UniversityModel
    {
        private string name;


        private List<ClassModel> classes = new List<ClassModel>();

        public string Name { get => name ; set => name = value; }
        internal List<ClassModel> Classes { get => classes; set => classes = value; }


        public List<StudentModel> ShowImportantInfTop10Depament()
        {
            /// name
            
            return null;
        }
    }
}
