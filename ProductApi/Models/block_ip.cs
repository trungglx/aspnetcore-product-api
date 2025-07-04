using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class block_ip
{
    public string ip { get; set; } = null!;

    public string? comment { get; set; }
}
