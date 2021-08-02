using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.Models
{
  [Table("course_student")]
  public class CourseStudent
  {
    public int Id { get; set; }

    [Required()]
    [DisplayName("Course")]
    [ForeignKey("Course")]
    public int Id_Course { get; set; }

    [Required()]
    [DisplayName("Student")]
    [ForeignKey("Student")]
    public int Id_Student { get; set; }

    public virtual Course Course { get; set; }
    public virtual Student Student { get; set; }
  }
}