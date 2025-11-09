using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagement.DAL.Models;

public partial class Class
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ClassId { get; set; }

    public string ClassName { get; set; } = null!;

    public string? Department { get; set; }

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
