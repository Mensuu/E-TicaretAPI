using System;
using System.Collections.Generic;

namespace WebApplication2.Models;

public partial class OdemeParam
{
    public int OdemeId { get; set; }

    public int Musteri { get; set; }

    public DateTime? OdemeTarihi { get; set; }

    public int ParaBirimi { get; set; }

    public decimal ToplamTutar { get; set; }

    public int OdemeKanali { get; set; }

    public string? Aciklama { get; set; }

}
