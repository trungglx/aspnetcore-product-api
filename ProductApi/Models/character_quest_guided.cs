using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class character_quest_guided
{
    public uint char_id { get; set; }

    public ushort quest { get; set; }

    public int? count { get; set; }

    public byte? state { get; set; }

    public long? date { get; set; }
}
