using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class character_labyrinth_zone
{
    public uint char_id { get; set; }

    public byte idx { get; set; }

    public byte subidx { get; set; }

    public byte? mission_id_1 { get; set; }

    public byte? mission_id_2 { get; set; }

    public byte? mission_id_3 { get; set; }

    public byte? mission_id_4 { get; set; }

    public byte? mission_id_5 { get; set; }

    public int? mission_count_1 { get; set; }

    public int? mission_count_2 { get; set; }

    public int? mission_count_3 { get; set; }

    public int? mission_count_4 { get; set; }

    public int? mission_count_5 { get; set; }
}
