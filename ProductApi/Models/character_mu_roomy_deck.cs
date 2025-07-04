using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class character_mu_roomy_deck
{
    public uint? char_id { get; set; }

    public byte? type { get; set; }

    public byte? slot { get; set; }

    public byte? color { get; set; }

    public byte? number { get; set; }

    public byte? state { get; set; }

    public byte? play_slot { get; set; }
}
