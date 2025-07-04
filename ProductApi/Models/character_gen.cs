using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class character_gen
{
    public uint char_id { get; set; }

    public byte family { get; set; }

    public byte? level { get; set; }

    public int? contribution { get; set; }

    public long? reward_date { get; set; }

    public long? join_date { get; set; }

    public long? left_date { get; set; }
}
