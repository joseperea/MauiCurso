using MauiAppCurso.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppCurso.MVVM.ViewModels
{
    public class PeopleViewModel
    {
        public PeopleViewModel()
        {
            People = new()
            {
                new Person { Name = "Juan", Edad = 48, BirthDate = new DateTime(1974, 9, 23), IsMarried =true, LunchTime = new TimeSpan(12, 30, 0), Weight = 89 },
                new Person { Name = "Ledys", Edad = 38, BirthDate = new DateTime(1974, 9, 23), IsMarried =true, LunchTime = new TimeSpan(12, 30, 0), Weight = 89 },
                new Person { Name = "Geralin", Edad = 28, BirthDate = new DateTime(1974, 9, 23), IsMarried =true, LunchTime = new TimeSpan(12, 30, 0), Weight = 89 },
                new Person { Name = "Ronal", Edad = 18, BirthDate = new DateTime(1974, 9, 23), IsMarried =false, LunchTime = new TimeSpan(12, 30, 0), Weight = 89 },
                new Person { Name = "Valery", Edad = 8, BirthDate = new DateTime(1974, 9, 23), IsMarried =false, LunchTime = new TimeSpan(12, 30, 0), Weight = 89 },
                new Person { Name = "Omaira", Edad = 58, BirthDate = new DateTime(1974, 9, 23), IsMarried =true, LunchTime = new TimeSpan(12, 30, 0), Weight = 89 },
                new Person { Name = "Martiana", Edad = 18, BirthDate = new DateTime(1974, 9, 23), IsMarried =false, LunchTime = new TimeSpan(12, 30, 0), Weight = 89 },
            };

            //People = new List<string>()
            //{
            //    "Juan",
            //    "Ledys",
            //    "Geralin",
            //    "Ronal",
            //    "Valery",
            //    "Omaira",
            //    "Martiana"
            //};
        }

        public List<Person> People { get; set; }
        //public List<string> People { get; set; }
    }
}
