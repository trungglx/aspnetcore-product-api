using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class character_gens_kill
{
    public uint? char_id { get; set; }

    public uint? killed_id { get; set; }

    public uint? count { get; set; }

    public long? date { get; set; }
}
