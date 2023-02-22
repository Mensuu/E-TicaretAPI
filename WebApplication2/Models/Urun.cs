using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WebApplication2.Models;

public partial class Urun
{
    public int UrunId { get; set; }

    public string UrunAdi { get; set; } = null!;

    public string UrunKodu { get; set; } = null!;

    public int ParaBirimiId { get; set; }

    public decimal Fiyati { get; set; }

    public int Stok { get; set; }

    public string? Aciklama { get; set; }
    public int UrunKategorisiId { get; set; }

    [JsonIgnore]
    public virtual ParaBirimi ParaBirimi { get; set; } = null!;
    public virtual UrunKategorisi UrunKategorisi { get; set; } = null!;


    [JsonIgnore]
    public virtual ICollection<Tahsilat> Tahsilats { get; } = new List<Tahsilat>();
}
