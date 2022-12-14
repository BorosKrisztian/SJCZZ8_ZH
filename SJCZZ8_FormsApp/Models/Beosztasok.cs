using System;
using System.Collections.Generic;

namespace SJCZZ8_FormsApp.Models;

public partial class Beosztasok
{
    public int BeosztasId { get; set; }

    public string? Beosztasnev { get; set; }

    public int? Elvart { get; set; }

    public virtual ICollection<Oktatok> Oktatok { get; } = new List<Oktatok>();
}
