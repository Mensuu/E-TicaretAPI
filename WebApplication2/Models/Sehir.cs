using System;
using System.Collections.Generic;

namespace WebApplication2.Models;

public partial class Sehir
{
    public int SehirId { get; set; }

    public string Sehir1 { get; set; } = null!;

    public virtual Musteri? Musteri { get; set; }
}
