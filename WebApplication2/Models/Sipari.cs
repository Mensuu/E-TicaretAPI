using System;
using System.Collections.Generic;

namespace WebApplication2.Models;

public partial class Sipari
{
    public int SiparisId { get; set; }

    public int MusteriId { get; set; }

    public DateTime? SiparisTarihi { get; set; }

    public int ParaBirimiId { get; set; }

    public decimal ToplamTutar { get; set; }

    public string? SiparisDetayları { get; set; }

    public int SiparisDurumuId { get; set; }

    public virtual Musteri Musteri { get; set; } = null!;

    public virtual ParaBirimi ParaBirimi { get; set; } = null!;

    public virtual SiparisDurumu SiparisDurumu { get; set; } = null!;

}
