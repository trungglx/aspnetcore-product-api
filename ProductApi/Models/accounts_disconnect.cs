using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class accounts_disconnect
{
    public uint account_id { get; set; }

    public ushort? server { get; set; }

    public sbyte? masive { get; set; }
}
