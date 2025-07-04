using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class accounts_security
{
    public uint account_id { get; set; }

    public string? account { get; set; }

    public string? ip { get; set; }

    public string? mac { get; set; }

    public uint? disk_serial { get; set; }
}
