using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class accounts_warning
{
    public uint account_id { get; set; }

    public uint? disk_serial { get; set; }

    public long? block_date { get; set; }
}
