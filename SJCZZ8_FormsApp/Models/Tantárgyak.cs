using System;
using System.Collections.Generic;

namespace SJCZZ8_FormsApp.Models;

public partial class Tantárgyak
{
    public int Tkód { get; set; }

    public string? Tantárgynév { get; set; }

    public int? Tantárgyfelelős { get; set; }

    public string? Tantargykod { get; set; }

    public int? Kredit { get; set; }

    public virtual ICollection<Orak> Orak { get; } = new List<Orak>();
}
