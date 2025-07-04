using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class character_monster_soul
{
    public uint char_id { get; set; }

    public uint? type { get; set; }

    public uint id { get; set; }

    public int? amount { get; set; }
}
