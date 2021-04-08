using StudentManager.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    class Program
    {
        static ControllerCenter controllerCenter = new ControllerCenter();
        static void Main(string[] args)
        {
            controllerCenter.InfoManagerment();
            Console.ReadKey();
        }
    }
}
