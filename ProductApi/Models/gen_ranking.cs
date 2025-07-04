using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class gen_ranking
{
    public byte family { get; set; }

    public byte? level { get; set; }

    public byte? type { get; set; }

    public int? score { get; set; }

    public int? ranking { get; set; }

    public uint char_id { get; set; }
}
