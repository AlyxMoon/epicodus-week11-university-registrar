using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.Models
{
  [Table("course")]
  public class Course
  {
    public int Id { get; set; }

    [Required]
    [DisplayName("Course ID Label")]
    [Display(Prompt = "ENG_101")]
    public string Label { get; set; }

    [Required]
    [DisplayName("Full Course Name")]
    public string Name { get; set; }

    [Required]
    [DisplayName("Course Description")]
    public string Description { get; set; }

    public virtual ICollection<CourseStudent> JoinEntitiesStudent { get; set; }

    public Course ()
    {
      JoinEntitiesStudent = new HashSet<CourseStudent>();
    }
  }
}