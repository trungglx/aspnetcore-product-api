using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class guild_matching
{
    public uint guild_id { get; set; }

    public string? text { get; set; }

    public byte? interest_type { get; set; }

    public byte? level_range { get; set; }

    public ushort? class_type { get; set; }

    public uint? board_number { get; set; }

    public string? introduction_text { get; set; }

    public int? MinLevel { get; set; }

    public int? MaxLevel { get; set; }
}
