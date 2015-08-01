using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrankFrog.Models
{
    public class AppModel
    {
        public AppModel()
        {
            NewPerson = new Person();
        }

        public Person NewPerson { get; set; }
        public List<Person> People { get; set; }
    }
}