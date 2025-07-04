using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class character_jewel_bingo_grid
{
    public uint char_id { get; set; }

    public byte? type { get; set; }

    public byte? slot { get; set; }

    public byte? value { get; set; }
}
