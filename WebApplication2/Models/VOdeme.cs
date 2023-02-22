using System;
using System.Collections.Generic;

namespace WebApplication2.Models;

public partial class VOdeme
{
    public int OdemeId { get; set; }

    public string Kime { get; set; }

    public DateTime? OdemeTarihi { get; set; }

    public string ParaBirimi { get; set; }

    public decimal ToplamTutar { get; set; }

    public string OdemeKanali { get; set; }

    public string? Aciklama { get; set; }

}
