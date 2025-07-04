using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class event_mini_bomb_ranking
{
    public uint char_id { get; set; }

    public byte? state { get; set; }

    public ushort? score { get; set; }

    public byte? bombs_founded { get; set; }

    public byte? bombs_failed { get; set; }
}
