﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    class University
    {
        private string name;
        public string Name   
        {
            get { return name; }   
            set { name = value; }  
        }

        internal List<Department> Departments { get => departments; set => departments = value; }

        private List<Department> departments  = new List<Department>();

        public virtual void TryAbstract(int year)
        {
            Console.WriteLine("From University " + year);
        }
        
    }
}
