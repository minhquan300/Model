using Lab3_Validation.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab3_Validation.Controllers;

public class StudentController : Controller
{
    // Danh sách lưu trong bộ nhớ để minh họa bài thực hành.
    private static readonly List<Student> Students = new()
    {
        new Student
        {
            Id = 1,
            Name = "Nguyễn Văn An",
            Email = "an@gmail.com",
            Password = "Abc12345@",
            Branch = Lab3_Validation.Models.Branch.IT,
            Gender = Lab3_Validation.Models.Gender.Nam,
            IsRegular = true,
            Address = "Hà Nội",
            DateOfBirth = new DateTime(2004, 5, 10),
            Score = 8.5
        }
    };

    public IActionResult Index()
    {
        return View(Students);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View(new Student());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Student student)
    {
        if (!ModelState.IsValid)
        {
            return View(student);
        }

        student.Id = Students.Count == 0 ? 1 : Students.Max(s => s.Id) + 1;
        Students.Add(student);

        TempData["Success"] = "Thêm sinh viên thành công.";
        return RedirectToAction(nameof(Index));
    }
}
