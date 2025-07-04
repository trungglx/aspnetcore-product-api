using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class character_item_pentagram
{
    public int GUID { get; set; }

    public byte[]? PentagramInventoryData { get; set; }

    public short INV_TYPE { get; set; }
}
