using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class character_labyrinth_level
{
    public uint char_id { get; set; }

    public ushort? level { get; set; }

    public int? amount { get; set; }
}
