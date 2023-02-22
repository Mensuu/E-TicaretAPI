using System;
using System.Collections.Generic;

namespace WebApplication2.Models;

public partial class SiparisParam
{
    public int SiparisId { get; set; }

    public int Musteri { get; set; }

    public DateTime? SiparisTarihi { get; set; }

    public int ParaBirimi { get; set; }

    public decimal ToplamTutar { get; set; }

    public string? SiparisDetayları { get; set; }

    public int SiparisDurumu { get; set; }

}
