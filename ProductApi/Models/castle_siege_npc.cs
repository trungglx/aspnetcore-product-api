using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class castle_siege_npc
{
    public long uid { get; set; }

    public short? id { get; set; }

    public short? defense_level { get; set; }

    public short? regen_level { get; set; }

    public short? life_level { get; set; }

    public int? life { get; set; }

    public short? npc { get; set; }
}
