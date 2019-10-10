using Realms;
using System;
using System.Collections.Generic;
using System.Text;

namespace WorkNote.Datas
{
    public class Employees : RealmObject
    {
        [PrimaryKey]
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeSurname { get; set; }
        public string EmployeeAge { get; set; }
        public string EmployeeCountry { get; set; }
    }
}
