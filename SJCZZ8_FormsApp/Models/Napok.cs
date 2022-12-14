using System;
using System.Collections.Generic;

namespace SJCZZ8_FormsApp.Models;

public partial class Napok
{
    public int NapId { get; set; }

    public string? Nap { get; set; }

    public virtual ICollection<Orak> Orak { get; } = new List<Orak>();
}
