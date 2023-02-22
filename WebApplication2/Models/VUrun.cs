using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WebApplication2.Models;

public partial class VUrun
{
    public int UrunId { get; set; }

    public string UrunAdi { get; set; } = null!;

    public string UrunKodu { get; set; } = null!;

    public string ParaBirimi { get; set; }

    public decimal Fiyati { get; set; }

    public int Stok { get; set; }

    public string? Aciklama { get; set; }
    public string UrunKategorisi { get; set; }

}
