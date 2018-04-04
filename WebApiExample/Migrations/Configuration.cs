namespace WebApiExample.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApiExample.Models.WebApiExampleContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApiExample.Models.WebApiExampleContext context)
        {
            context.Contacts.AddOrUpdate(p => p.Name,
           new Models.Contacts
           {
               ContactId = 1,
               Name = "Jessica Diaz",
               Address = "Ctra. Valencia km 7",
               City = "Madrid",
               State = "Spain",
               Zip = "28555",
               Email = "jdiaz@etsisi.upm.es",
           },
           new Models.Contacts
           {
               ContactId = 2,
               Name = "Jennifer Perez",
               Address = "Ctra. Valencia km 7",
               City = "Madrid",
               State = "Spain",
               Zip = "28555",
               Email = "jperez@etsisi.upm.es",
           },
           new Models.Contacts
           {
               ContactId = 1,
               Name = "Agustin Yague",
               Address = "Ctra. Valencia km 7",
               City = "Madrid",
               State = "Spain",
               Zip = "28555",
               Email = "ayague@etsisi.upm.es",
           }

           );
        }
    }
}
