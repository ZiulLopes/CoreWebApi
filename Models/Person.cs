using System;

namespace webapi.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public bool Active { get; set; }
        public DateTime DTCADPERSON { get; set; }
    }
}