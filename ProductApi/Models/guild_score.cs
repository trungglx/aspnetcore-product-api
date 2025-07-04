using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class guild_score
{
    public uint guild_id { get; set; }

    public long? score { get; set; }
}
