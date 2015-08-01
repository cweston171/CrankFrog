using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CrankFrog.Models;

namespace CrankFrog.DAL
{
    public class PersonInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<PersonContext>
    {
        protected override void Seed(PersonContext context)
        {
            var people = new List<Person>
            {
                new Person { Name = "Chase Weston", StreetAddress = "825 Fremont Ave", City = "Salt Lake City", State = "UT", DateOfEntry = DateTime.Now },
                new Person { Name = "Superman", StreetAddress = "456 Super Street", City = "Phoenix", State = "AZ", DateOfEntry = DateTime.Now },
                new Person { Name = "Batman", StreetAddress = "1234 E. Old Gotham Hwy", City = "Gotham", State = "NY", DateOfEntry = DateTime.Now },
                new Person { Name = "Iron Man", StreetAddress = "85 Iron Ave", City = "New York", State = "NY", DateOfEntry = DateTime.Now },
                new Person { Name = "Spider-Man", StreetAddress = "4E Silk String St", City = "New York", State = "NY", DateOfEntry = DateTime.Now },
                new Person { Name = "Thor", StreetAddress = "1342 W Rainbow Rd", City = "Valhalla", State = "FL", DateOfEntry = DateTime.Now },
                new Person { Name = "Black Widow", StreetAddress = "85 Iron Ave", City = "New York", State = "NY", DateOfEntry = DateTime.Now }
            };

            people.ForEach(p => context.People.Add(p));
            context.SaveChanges();
        }
    }
}