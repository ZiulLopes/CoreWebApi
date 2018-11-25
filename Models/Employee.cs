using System;

namespace webapi.Models
{
    public class EMPLOYEE
    {
        public int EmployeeId {get; set;}
        public string NameEmployee { get; set; }
        public bool Active { get; set; }

        public DateTime DtCadEmployee { get; set; }
    }
}