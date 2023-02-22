using System;
using System.Collections.Generic;

namespace WebApplication2.Models;

public partial class Odeme
{
    public int OdemeId { get; set; }

    public int MusteriId { get; set; }

    public DateTime? OdemeTarihi { get; set; }

    public int ParaBirimiId { get; set; }

    public decimal ToplamTutar { get; set; }

    public int OdemeKanaliId { get; set; }

    public string? Aciklama { get; set; }

    public virtual Musteri Musteri { get; set; } = null!;

    public virtual OdemeKanali OdemeKanali { get; set; } = null!;

    public virtual ParaBirimi ParaBirimi { get; set; } = null!;
}
