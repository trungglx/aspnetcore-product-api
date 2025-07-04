using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class character_mini_bomb
{
    public uint char_id { get; set; }

    public byte? state { get; set; }

    public ushort? score { get; set; }

    public int? total_score { get; set; }

    public long? cdate { get; set; }
}
