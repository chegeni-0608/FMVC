using FMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FMVC.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
           Students student1 = new Students();
            student1.StudentId = 1;
            student1.StudentName = "مرتضی";
            student1.StudentFamily = "چگنی";
            student1.StudentAge = 60;

            return View(student1);
        }

        public ActionResult UserManage()
        {
            List<Students> studentsList = new List<Students>()
            {
                new Students(1,"مرتضی","چگنی",42),
                new Students(1,"آرین","رحمانی شیواری اصل میاندوآبی",24),
                 new Students(2,"ابوالفضل","حاجی باقری",44),
                  new Students(3,"صادق","موحدی",46),
                   new Students(4,"سامیار","افشاریان",23),
                    new Students(5,"علی","خوشدونی",25),
                     new Students(6,"داوود","مصطفوی",27),
                      new Students(7,"مهشید","ذوالفقاری",35),
                       new Students(8,"سحر","روستایی",30),
                        new Students(9,"مونا","اصفهانی",42),
                        new Students(10,"مهرداد","سلیمی",42),
                         new Students(11,"علیرضا","سلطانی",44),
                          new Students(12,"علیرضا","نقدی",46),
                           new Students(13,"محسن","حسنوند",23),
                            new Students(14,"میثم ","حاتمی",25),
                             new Students(15,"داوود","آقازاده",27),
                              new Students(16,"آرزو","آقایاری",35),
                              new Students(17,"نسیم","شیروانی",30),
                               new Students(18,"علی اکبر","زمانی",42),
            };

            return View(studentsList);
        }

        public ActionResult UpdateStudent()
        {
            return View();
        }


        public ActionResult DeleteStudent()
        {
            return View();
        }

    }
}