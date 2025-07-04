using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class character_quest_evo
{
    public uint char_id { get; set; }

    public byte id { get; set; }

    public byte? state { get; set; }

    public int? kill_count_1 { get; set; }

    public int? kill_count_2 { get; set; }

    public int? kill_count_3 { get; set; }

    public int? kill_count_4 { get; set; }

    public int? kill_count_5 { get; set; }
}
