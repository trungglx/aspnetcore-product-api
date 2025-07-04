using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class event_mu_roomy_ranking
{
    public uint char_id { get; set; }

    public byte? type { get; set; }

    public ushort? score { get; set; }

    public byte? remain_card { get; set; }

    public byte? remain_special_card { get; set; }
}
