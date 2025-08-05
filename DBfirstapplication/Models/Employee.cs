using System;
using System.Collections.Generic;

namespace DBfirstapplication.Models;

public partial class Employee
{
    public int Empid { get; set; }

    public string? Name { get; set; }

    public string? Department { get; set; }

    public int? Salary { get; set; }
}
