using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    [Serializable]
    class DepartmentModel: UniversityModel
    {
        public List<ClassModel> _classes = new List<ClassModel>();
    }
}
