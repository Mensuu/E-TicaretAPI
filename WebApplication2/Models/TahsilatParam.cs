using System;
using System.Collections.Generic;

namespace WebApplication2.Models;

public partial class TahsilatParam
{
    public int TahsilatId { get; set; }

    public int Musteri { get; set; }

    public int ParaBirimi { get; set; }

    public decimal ToplamTutar { get; set; }

    public int Urun { get; set; }

    public int TahsilatTipi { get; set; }

}
