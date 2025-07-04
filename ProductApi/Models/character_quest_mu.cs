using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class character_quest_mu
{
    public uint char_id { get; set; }

    public ushort quest_id { get; set; }

    public byte? state { get; set; }

    public ushort? objective { get; set; }

    public long? date { get; set; }
}
