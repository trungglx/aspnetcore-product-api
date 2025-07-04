using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class serial_check
{
    public ushort server { get; set; }

    public uint serial { get; set; }

    public byte? type { get; set; }

    public uint? account_id { get; set; }

    public string? ip { get; set; }

    public string? mac { get; set; }

    public uint? disk_serial { get; set; }
}
