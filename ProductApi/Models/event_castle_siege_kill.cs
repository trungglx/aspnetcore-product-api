using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class event_castle_siege_kill
{
    public uint? char_id { get; set; }

    public string? char_name { get; set; }

    public byte? char_rank { get; set; }

    public byte? state { get; set; }

    public string? player_data_01 { get; set; }

    public uint? guild_id_01 { get; set; }

    public string? guild_name_01 { get; set; }

    public uint? killer_id { get; set; }

    public string? killer_name { get; set; }

    public byte? killer_rank { get; set; }

    public string? player_data_02 { get; set; }

    public uint? guild_id_02 { get; set; }

    public string? guild_name_02 { get; set; }

    public ushort? world { get; set; }

    public short? world_x { get; set; }

    public short? world_y { get; set; }
}
