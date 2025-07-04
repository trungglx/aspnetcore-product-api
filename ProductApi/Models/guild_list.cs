using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class guild_list
{
    public uint guid { get; set; }

    public string? name { get; set; }

    public string? emblem { get; set; }

    public uint? hostil { get; set; }

    public uint? alliance { get; set; }

    public string? notice { get; set; }

    public int? score { get; set; }
}
