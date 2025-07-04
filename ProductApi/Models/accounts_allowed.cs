using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class accounts_allowed
{
    public uint account_id { get; set; }

    public uint? guid { get; set; }

    public ushort? server { get; set; }
}
