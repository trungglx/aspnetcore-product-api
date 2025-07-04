using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class event_labyrinth_league
{
    public byte category { get; set; }

    public uint char_id { get; set; }

    public string? char_name { get; set; }

    public byte? char_class { get; set; }

    public int? score { get; set; }

    public int? league_score { get; set; }

    public long? time { get; set; }
}
