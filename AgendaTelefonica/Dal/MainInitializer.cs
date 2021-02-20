using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using AgendaTelefonica.Models;

namespace AgendaTelefonica.DAL
{
    public class MainInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<MainContext>
    {
        protected override void Seed(MainContext context)
        {
            var students = new List<People>
            {
            new People{Name="Carson",Phone="4396856458",Address="Rua A"},
            new People{Name="Meredith",Phone="4396856458",Address="Rua B"},
            new People{Name="Arturo",Phone="4396856458",Address="Rua C"}
            };

            students.ForEach(s => context.Peoples.Add(s));
            context.SaveChanges();
            var enrollments = new List<Enrollment>
            {
            new Enrollment{PeopleID=1},
            new Enrollment{PeopleID=2},
            new Enrollment{PeopleID=3}
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}