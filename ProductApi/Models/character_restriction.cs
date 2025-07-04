using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class character_restriction
{
    public uint char_id { get; set; }

    public uint? restriction { get; set; }

    public long? time { get; set; }

    public string? admin_name { get; set; }

    public string? reason { get; set; }
}
