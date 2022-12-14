using System;
using System.Collections.Generic;

namespace SJCZZ8_FormsApp.Models;

public partial class Termek
{
    public int Tkód { get; set; }

    public string? Terem { get; set; }

    public virtual ICollection<Orak> Orak { get; } = new List<Orak>();
}
