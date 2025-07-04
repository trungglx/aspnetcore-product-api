using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class character_numeric_baseball
{
    public uint char_id { get; set; }

    public byte? state { get; set; }

    public int? score { get; set; }

    public byte? number_1 { get; set; }

    public byte? number_2 { get; set; }

    public byte? number_3 { get; set; }

    public string? numbers { get; set; }

    public string? strikes { get; set; }

    public string? balls { get; set; }
}
