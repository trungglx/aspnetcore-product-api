using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class character_date
{
    public uint char_id { get; set; }

    public uint id { get; set; }

    public long? date { get; set; }
}
