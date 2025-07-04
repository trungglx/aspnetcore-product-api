using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class castle_siege_datum
{
    public uint owner { get; set; }

    public byte? status { get; set; }

    public int? tax_hunt { get; set; }

    public byte? tax_chaos { get; set; }

    public byte? tax_store { get; set; }

    public sbyte? hunt_allowed { get; set; }

    public ulong? money { get; set; }
}
