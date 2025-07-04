using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class event_scramble_ranking
{
    public uint char_id { get; set; }

    public string? word { get; set; }

    public string? shuffle_word { get; set; }
}
