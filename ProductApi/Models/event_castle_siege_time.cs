using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class event_castle_siege_time
{
    public uint? char_id { get; set; }

    public string? char_name { get; set; }

    public byte? char_rank { get; set; }

    public string? player_data { get; set; }

    public uint? guild_id { get; set; }

    public string? guild_name { get; set; }

    public byte? type { get; set; }

    public uint? time { get; set; }
}
