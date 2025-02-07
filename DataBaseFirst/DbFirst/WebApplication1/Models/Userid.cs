using System;
using System.Collections.Generic;

namespace WebApplication1.Models;

public partial class Userid
{
    public int UserId1 { get; set; }

    public string UserName { get; set; } = null!;

    public virtual ICollection<Workingexperience> Workingexperiences { get; set; } = new List<Workingexperience>();
}
