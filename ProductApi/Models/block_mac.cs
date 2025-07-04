using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class block_mac
{
    public string mac { get; set; } = null!;

    public string? comment { get; set; }
}
