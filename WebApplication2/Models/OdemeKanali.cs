using System;
using System.Collections.Generic;

namespace WebApplication2.Models;

public partial class OdemeKanali
{
    public int OdemeKanaliId { get; set; }

    public string OdemeKanali1 { get; set; } = null!;

    public virtual ICollection<Odeme> Odemes { get; } = new List<Odeme>();
}
