using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class event_ranking
{
    public byte event_id { get; set; }

    public byte? event_ground { get; set; }

    public uint char_id { get; set; }

    public long? score { get; set; }
}
