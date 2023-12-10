using System;
using System.Collections.Generic;

namespace ZH2.Models;

public partial class Vendeg
{
    public string Usernev { get; set; } = null!;

    public string Nev { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? SzamlCim { get; set; }

    public DateTime? SzulDat { get; set; }
}
