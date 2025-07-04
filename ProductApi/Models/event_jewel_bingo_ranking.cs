using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class event_jewel_bingo_ranking
{
    public uint char_id { get; set; }

    public byte? type { get; set; }

    public int? score1 { get; set; }

    public int? score2 { get; set; }

    public int? score3 { get; set; }
}
