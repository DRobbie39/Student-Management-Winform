using System;
using System.Collections.Generic;

namespace StudentManagement.DAL.Models;

public partial class Subject
{
    public int SubjectId { get; set; }

    public string SubjectName { get; set; } = null!;

    public virtual ICollection<Score> Scores { get; set; } = new List<Score>();
}
