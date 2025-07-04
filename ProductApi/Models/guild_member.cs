using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class guild_member
{
    public uint guild_id { get; set; }

    public uint char_id { get; set; }

    public byte? id { get; set; }

    public byte? ranking { get; set; }
}
