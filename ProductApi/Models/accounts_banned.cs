using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class accounts_banned
{
    public uint account_id { get; set; }

    public uint? guid { get; set; }

    public long? unban_date { get; set; }
}
