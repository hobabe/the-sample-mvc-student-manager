using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    [Serializable]
    class UniversityModel
    {
        public List<DepartmentModel> _departmentModels = new List<DepartmentModel>();
    }
}
