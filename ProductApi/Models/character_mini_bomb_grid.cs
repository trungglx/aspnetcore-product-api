using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class character_mini_bomb_grid
{
    public uint char_id { get; set; }

    public byte? cell { get; set; }

    public byte? value { get; set; }

    public byte? status { get; set; }
}
