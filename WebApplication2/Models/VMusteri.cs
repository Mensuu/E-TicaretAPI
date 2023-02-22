using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using WebApplication2.Models;

namespace WebApplication2.Models;

public partial class VMusteri
{
  
    public int MusteriId { get; set; }

    public string MusteriAdi { get; set; } = null!;

    public string MusteriSoyadi { get; set; } = null!;
    public string Cinsiyet { get; set; }

    public DateTime? DogumTarihi { get; set; }

    public string? Adres { get; set; }

    public string Sehir { get; set; }

}