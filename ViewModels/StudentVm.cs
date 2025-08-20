using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


    namespace SchoolMgmt.Web.ViewModels
    {
        public class StudentVm
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public DateTime DOB { get; set; }
            public string Gender { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }

            public List<QualificationVm> Qualifications { get; set; }
        }
    }

