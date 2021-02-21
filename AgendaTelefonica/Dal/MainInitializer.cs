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
            var contacts = new List<People>
            {
            new People{Name="Victor Gabriel",Phone="(43) 99856-1548",Address="Rua Presidente Castelo Branco 123"},
            new People{Name="João Paulo",Phone="(43) 98846-7548",Address="Rua Marechal Fonsecca 1200"},
            new People{Name="Antônio Lopes",Phone="(43) 91856-2548",Address="Rua Coronel Capucho 122"},
            new People{Name="Gabriel Felipe",Phone="(43) 99856-2548",Address="Rua Benetido 45"},
            new People{Name="João Paulo",Phone="(43) 98846-7548",Address="Rua Arthur Fonseca 78"},
            new People{Name="Fernanda Lima",Phone="(43) 98156-1148",Address="Rua Benetido 52"},
            new People{Name="Jéssica Santos",Phone="(11) 91246-4548",Address="Rua Presidente Castelo Branco 128"},
            new People{Name="Larissa Silva",Phone="(11) 99511-2348",Address="Rua Arthur Fonseca 85"},
            new People{Name="Thaís Mendes",Phone="(11) 99242-2348",Address="Rua Coronel Capucho 125"},
            new People{Name="Renato Rodriguez",Phone="(11) 99811-5648",Address="Rua Coronel Capucho 132"}
            };

            contacts.ForEach(s => context.Peoples.Add(s));
            context.SaveChanges();
            var enrollments = new List<Enrollment>
            {
            new Enrollment{PeopleID=1},
            new Enrollment{PeopleID=2},
            new Enrollment{PeopleID=3},
            new Enrollment{PeopleID=4},
            new Enrollment{PeopleID=5},
            new Enrollment{PeopleID=6},
            new Enrollment{PeopleID=7},
            new Enrollment{PeopleID=8},
            new Enrollment{PeopleID=9},
            new Enrollment{PeopleID=10}
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}