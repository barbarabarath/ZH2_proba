using System;
using System.Collections.Generic;

namespace ZH2.Models;

public partial class Foglalas
{
    public int FoglalasPk { get; set; }

    public string UgyfelFk { get; set; } = null!;

    public int SzobaFk { get; set; }

    public DateTime Mettol { get; set; }

    public DateTime Meddig { get; set; }

    public int FelnottSzam { get; set; }

    public int GyermekSzam { get; set; }
}
