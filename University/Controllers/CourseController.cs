using System.Linq;
using Microsoft.AspNetCore.Mvc;
using University.Models;

namespace University.Controllers
{
  [Route("/courses")]
  public class CourseController : Controller
  {
    private readonly DatabaseContext _db;

    public CourseController(DatabaseContext db)
    {
      _db = db;
    }

    [HttpGet]
    public ActionResult Index ()
    {
      return View(_db.Courses.ToList());
    }

    [HttpPost]
    public ActionResult Create (Course item)
    {
      _db.Courses.Add(item);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [HttpGet("{courseId}")]
    public ActionResult Details (int courseId)
    {
      Course item = _db.Courses.FirstOrDefault(item => item.Id == courseId);

      return View(item);
    }

    [HttpGet("{courseId}/remove")]
    public ActionResult Remove (int courseId)
    {
      Course item = _db.Courses.FirstOrDefault(item => item.Id == courseId);
      _db.Courses.Remove(item);
      _db.SaveChanges();
      
      return RedirectToAction("Index");
    }
  }
}