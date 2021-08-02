using System.Linq;
using Microsoft.AspNetCore.Mvc;
using University.Models;

namespace University.Controllers
{
  [Route("/students")]
  public class StudentController : Controller
  {
    private readonly DatabaseContext _db;

    public StudentController(DatabaseContext db)
    {
      _db = db;
    }

    [HttpGet]
    public ActionResult Index ()
    {
      return View(_db.Students.ToList());
    }

    [HttpPost]
    public ActionResult Create (Student item)
    {
      _db.Students.Add(item);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [HttpGet("{studentId}")]
    public ActionResult Details (int studentId)
    {
      Student item = _db.Students.FirstOrDefault(item => item.Id == studentId);

      return View(item);
    }

    [HttpGet("{studentId}/remove")]
    public ActionResult Remove (int studentId)
    {
      Student item = _db.Students.FirstOrDefault(item => item.Id == studentId);
      _db.Students.Remove(item);
      _db.SaveChanges();
      
      return RedirectToAction("Index");
    }
  }
}
