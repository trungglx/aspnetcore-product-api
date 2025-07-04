using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class character_item_inventory
{
    public int GUID { get; set; }

    public byte[]? InventoryData { get; set; }
}
