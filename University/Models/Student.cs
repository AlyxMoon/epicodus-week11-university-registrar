using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.Models
{
  [Table("student")]
  public class Student
  {
    public int Id { get; set; }

    [Required]
    [DisplayName("Student Name")]
    public string Name { get; set; }

    [Required]
    [DisplayName("Enrollment Date")]
    [DataType(DataType.Date)]
    public DateTime EnrollmentDate { get; set; }

    public virtual ICollection<CourseStudent> JoinEntitiesCourse { get; set; }

    public Student ()
    {
      JoinEntitiesCourse = new HashSet<CourseStudent>();
    }
  }
}