using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class character_majestic_tree
{
    public uint char_id { get; set; }

    public byte? type { get; set; }

    public byte? section { get; set; }

    public ushort id { get; set; }

    public byte? level { get; set; }
}
