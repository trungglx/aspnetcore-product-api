using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class castle_siege_registered_guild
{
    public uint guild { get; set; }

    public uint? marks { get; set; }

    public uint? register_id { get; set; }

    public ushort? level { get; set; }

    public ushort? level_master { get; set; }
}
