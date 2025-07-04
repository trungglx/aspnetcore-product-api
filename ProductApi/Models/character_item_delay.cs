using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class character_item_delay
{
    public uint? char_id { get; set; }

    public ushort? item { get; set; }

    public long? date { get; set; }
}
