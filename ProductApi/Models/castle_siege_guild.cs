using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class castle_siege_guild
{
    public uint guild { get; set; }

    public byte side { get; set; }

    public int? score { get; set; }
}
