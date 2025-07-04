using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class character_deleted
{
    public uint account_id { get; set; }

    public uint char_id { get; set; }

    public string? name { get; set; }
}
