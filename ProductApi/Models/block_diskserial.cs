using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class block_diskserial
{
    public uint disk_serial { get; set; }

    public string? comment { get; set; }
}
