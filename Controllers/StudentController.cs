using System;
public ActionResult Index()
{
    var students = _service.GetAllStudents();
    return View(students);
}



public ActionResult Create()
{
    var vm = new StudentVm { Qualifications = new List<QualificationVm> { new QualificationVm() } };
    return View(vm);
}



[HttpPost]
[ValidateAntiForgeryToken]
public ActionResult Create(StudentVm vm)
{
    if (!ModelState.IsValid)
        return View(vm);


    
    var student = new Student
    {
        FirstName = vm.FirstName,
        LastName = vm.LastName,
        Age = vm.Age,
        DOB = vm.DOB,
        Gender = vm.Gender,
        Email = vm.Email,
        Phone = vm.Phone,
        Username = vm.Username,
        Password = vm.Password,
        
        StudentCode = GenerateStudentCode(),
        Qualifications = vm.Qualifications?.Select(q => new Qualification
        {
            Course = q.Course,
            University = q.University,
            Year = q.Year,
            Percentage = q.Percentage
        }).ToList()
    };


    _service.CreateStudent(student);
    return RedirectToAction("Index");
}


private string GenerateStudentCode()
{
   
    return "STU" + DateTime.Now.ToString("yyyyMMddHHmmssfff");
}
}