using System;
using System.Collections.Generic;

namespace SJCZZ8_FormsApp.Models;

public partial class Savok
{
    public int SavId { get; set; }

    public string? Sav { get; set; }

    public string? Időpont { get; set; }

    public virtual ICollection<Orak> Orak { get; } = new List<Orak>();
}
