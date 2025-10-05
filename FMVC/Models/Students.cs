using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FMVC.Models
{
    public class Students
    {
        public int  StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentFamily { get; set; }
        public int StudentAge { get; set; }

        public Students() { }
        public Students(int Id, string Name, string Family, int Age)
        {
            StudentId = Id;
            StudentName = Name;
            StudentFamily = Family;
            StudentAge = Age;

        }
       
        

    }
}