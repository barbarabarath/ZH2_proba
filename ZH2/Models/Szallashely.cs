using System;
using System.Collections.Generic;

namespace ZH2.Models;

public partial class Szallashely
{
    public int SzallasId { get; set; }

    public string SzallasNev { get; set; } = null!;

    public string? Hely { get; set; }

    public int? CsillagokSzama { get; set; }

    public string? Tipus { get; set; }

    public string Rogzitette { get; set; } = null!;

    public DateTime RogzIdo { get; set; }

    public string? Cim { get; set; }

    public virtual ICollection<Szoba> Szoba { get; set; } = new List<Szoba>();
}
