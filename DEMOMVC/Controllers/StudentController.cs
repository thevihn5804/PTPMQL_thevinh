using DEMOMVC.Data;
using DEMOMVC.Models;
using Microsoft.AspNetCore.Mvc;

public class StudentController : Controller
{
    private readonly ApplicationDbContext _context;
    private readonly AutoGenerateCode _autoGenerateCode;
    public StudentController(ApplicationDbContext context, AutoGenerateCode autoGenerateCode)
    {
        _context = context;
        _autoGenerateCode = autoGenerateCode;
    }
    public IActionResult Create()//Get; Student/Create
    {
        var lastStudent = _context.Students.OrderByDescending(s => s.StudentID).FirstOrDefault();
        var lastID = lastStudent?.StudentID ?? "STD000";
        string newStudentID = _autoGenerateCode.GenerateCode(lastID);
        ViewBag.NewStudentID = newStudentID;

        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Create(Student student)
    {
        if (ModelState.IsValid)
        {
            _context.Add(student);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(student);
    }
}