using System;
using System.Collections.Generic;

namespace StudentManagement.DAL.Models;

public partial class Account
{
    public int AccountId { get; set; }

    public string Username { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public DateOnly? CreatedDate { get; set; }
}
