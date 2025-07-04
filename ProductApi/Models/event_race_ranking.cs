using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class event_race_ranking
{
    public uint char_id { get; set; }

    public string race { get; set; } = null!;

    public string? start { get; set; }
}
