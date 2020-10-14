using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class EmployeeDetail_Model
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string Address { get; set; }
        public string Hobbies { get; set; }
        public int EmpId { get; set; }
        public List<EmployeeDetail_Model> alldata { get; set; }
    }
}
