using MauiAppCurso.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppCurso.MVVM.ViewModels
{
    public class PersonViewModel
    {
        public PersonViewModel()
        {
            Person = new Person 
            {
                Name= "Jose Valencia",
                Edad = 31,
                BirthDate= new DateTime(1992,01,02),
                IsMarried= false,
                LunchTime= new TimeSpan(1,0,0),
                Weight = 80

            };

        }

        public Person Person { get; set; }
    }
}
