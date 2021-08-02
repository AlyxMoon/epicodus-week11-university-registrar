using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.Models
{
  [Table("course")]
  public class Course
  {
    public int Id { get; set; }
    public string Label { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public virtual ICollection<CourseStudent> JoinEntitiesStudent { get; set; }

    public Course ()
    {
      JoinEntitiesStudent = new HashSet<CourseStudent>();
    }
  }
}