using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WebApplication2.Models;

public partial class UrunKategorisi
{
    public int UrunKategorisiId { get; set; }

    public string UrunKategorisi1 { get; set; } = null!;

    [JsonIgnore]
    public virtual ICollection<Urun> Uruns { get; } = new List<Urun>();

}
