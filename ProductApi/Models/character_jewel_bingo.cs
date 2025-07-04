using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class character_jewel_bingo
{
    public uint char_id { get; set; }

    public byte? state { get; set; }

    public byte? box { get; set; }

    public byte? count { get; set; }

    public byte? jewel { get; set; }

    public int? score1 { get; set; }

    public int? score2 { get; set; }

    public int? score3 { get; set; }

    public long? date { get; set; }
}
