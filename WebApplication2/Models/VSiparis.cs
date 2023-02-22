using System;
using System.Collections.Generic;

namespace WebApplication2.Models;

public partial class VSiparis
{
    public int SiparisId { get; set; }

    public string SiparisVeren { get; set; }

    public DateTime? SiparisTarihi { get; set; }

    public string ParaBirimi { get; set; }

    public decimal ToplamTutar { get; set; }

    public string? SiparisDetayları { get; set; }

    public string SiparisDurumu { get; set; }

}
