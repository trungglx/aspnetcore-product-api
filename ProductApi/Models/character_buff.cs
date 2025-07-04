using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class character_buff
{
    public uint char_id { get; set; }

    public ushort buff { get; set; }

    public byte? effect_1 { get; set; }

    public int? value_1 { get; set; }

    public byte? effect_2 { get; set; }

    public int? value_2 { get; set; }

    public byte? effect_3 { get; set; }

    public int? value_3 { get; set; }

    public long? duration { get; set; }

    public byte? flags { get; set; }
}
