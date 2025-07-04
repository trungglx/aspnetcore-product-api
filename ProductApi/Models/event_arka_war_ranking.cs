using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class event_arka_war_ranking
{
    public uint? guild_id_01 { get; set; }

    public string? guild_name_01 { get; set; }

    public uint? guild_id_02 { get; set; }

    public string? guild_name_02 { get; set; }

    public int? character_count { get; set; }
}
