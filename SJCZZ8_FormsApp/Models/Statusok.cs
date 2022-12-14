using System;
using System.Collections.Generic;

namespace SJCZZ8_FormsApp.Models;

public partial class Statusok
{
    public int Skod { get; set; }

    public string? Status { get; set; }

    public virtual ICollection<Oktatok> Oktatok { get; } = new List<Oktatok>();
}
