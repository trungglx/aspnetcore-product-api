using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class character_skill
{
    public uint char_id { get; set; }

    public byte type { get; set; }

    public ushort skill { get; set; }

    public byte? skill_level { get; set; }
}
