using System;
using System.Collections.Generic;

namespace SJCZZ8_FormsApp.Models;

public partial class Oktatok
{
    public int OktatoId { get; set; }

    public string? Nev { get; set; }

    public string? Titulus { get; set; }

    public int? Beosztás { get; set; }

    public int? Status { get; set; }

    public virtual Beosztasok? BeosztásNavigation { get; set; }

    public virtual ICollection<Orak> Orak { get; } = new List<Orak>();

    public virtual Statusok? StatusNavigation { get; set; }
}
