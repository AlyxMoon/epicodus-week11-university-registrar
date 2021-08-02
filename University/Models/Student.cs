using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.Models
{
  [Table("student")]
  public class Student
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime EnrollmentDate { get; set; }

    public virtual ICollection<CourseStudent> JoinEntitiesCourse { get; set; }

    public Student ()
    {
      JoinEntitiesCourse = new HashSet<CourseStudent>();
    }
  }
}