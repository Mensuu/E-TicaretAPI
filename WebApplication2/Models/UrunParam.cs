using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WebApplication2.Models;

public partial class UrunParam
{
    public int UrunId { get; set; }

    public string UrunAdi { get; set; } = null!;

    public string UrunKodu { get; set; } = null!;

    public int ParaBirimi { get; set; }

    public decimal Fiyati { get; set; }

    public int Stok { get; set; }

    public string? Aciklama { get; set; }
    public int UrunKategorisi { get; set; }

}
