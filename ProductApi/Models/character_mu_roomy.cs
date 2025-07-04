using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class character_mu_roomy
{
    public uint char_id { get; set; }

    public byte? playing { get; set; }

    public byte? type { get; set; }

    public ushort? score { get; set; }

    public byte? card_count { get; set; }

    public byte? special_card_count { get; set; }

    public long? date { get; set; }
}
