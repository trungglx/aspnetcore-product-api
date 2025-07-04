using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class event_castle_siege_ranking
{
    public uint guild_id { get; set; }

    public string? guild_name { get; set; }

    public int? character_count { get; set; }
}
