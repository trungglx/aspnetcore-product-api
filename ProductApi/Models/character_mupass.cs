using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class character_mupass
{
    public long guid { get; set; }

    public long? character_id { get; set; }

    public int? pass_level { get; set; }

    public long? pass_exp { get; set; }

    public bool? gold_enabled { get; set; }

    public bool? premiun_enabled { get; set; }

    public bool? MuRevardEnabled { get; set; }

    public bool? MuRevardGoldEnabled { get; set; }

    public bool? MuRevardPremiumEnabled { get; set; }

    public int? TodayMuPassExp { get; set; }

    public byte[]? pass_data { get; set; }

    public byte[]? pass_reward_data { get; set; }

    public long? ticketCount { get; set; }
}
