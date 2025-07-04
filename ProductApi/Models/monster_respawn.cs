using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class monster_respawn
{
    public ushort server { get; set; }

    public ushort guid { get; set; }

    public long? date { get; set; }
}
