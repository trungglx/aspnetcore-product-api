using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class character_warp_favorite_list
{
    public uint char_id { get; set; }

    public byte? slot { get; set; }

    public ushort? data { get; set; }

    public ushort? warp_id { get; set; }
}
