using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    [Serializable]
    class ClassModel: DepartmentModel
    {
        public List<StudentModel> _students = new List<StudentModel>();
    }
}
