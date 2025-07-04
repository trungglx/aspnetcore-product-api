using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class character_statistic
{
    public uint char_id { get; set; }

    public uint statistic_id { get; set; }

    public ulong? count { get; set; }
}
