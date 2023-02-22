using System;
using System.Collections.Generic;

namespace WebApplication2.Models;

public partial class Tahsilat
{
    public int TahsilatId { get; set; }

    public int MusteriId { get; set; }

    public int ParaBirimiId { get; set; }

    public decimal ToplamTutar { get; set; }
    public int UrunId { get; set; }

    public int TahsilatTipiId { get; set; }

    public virtual Musteri Musteri { get; set; } = null!;

    public virtual ParaBirimi ParaBirimi { get; set; } = null!;

    public virtual Urun Urun { get; set; } = null!;

    public virtual TahsilatTipi TahsilatTipi { get; set; } = null!;
}
