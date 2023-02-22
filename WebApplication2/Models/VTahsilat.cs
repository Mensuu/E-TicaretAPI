using System;
using System.Collections.Generic;

namespace WebApplication2.Models;

public partial class VTahsilat
{
    public int TahsilatId { get; set; }

    public string Musteri { get; set; }

    public string ParaBirimi { get; set; }

    public decimal ToplamTutar { get; set; }

    public string İlgiliSiparis { get; set; }

    public string TahsilatTipi { get; set; }

}
