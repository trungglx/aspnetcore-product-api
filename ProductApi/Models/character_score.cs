using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class character_score
{
    public uint char_id { get; set; }

    public byte? type { get; set; }

    public int? level { get; set; }

    public int? score { get; set; }
}
