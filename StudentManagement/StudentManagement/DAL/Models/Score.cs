using System;
using System.Collections.Generic;

namespace StudentManagement.DAL.Models;

public partial class Score
{
    public int ScoreId { get; set; }

    public int StudentId { get; set; }

    public int SubjectId { get; set; }

    public double? Score1 { get; set; }

    public DateOnly? ExamDate { get; set; }

    public virtual Student Student { get; set; } = null!;

    public virtual Subject Subject { get; set; } = null!;
}
