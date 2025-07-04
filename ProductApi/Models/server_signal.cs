using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class server_signal
{
    public uint id { get; set; }

    public ushort? server { get; set; }

    public ushort? signal { get; set; }

    public int? data_1 { get; set; }

    public int? data_2 { get; set; }

    public int? data_3 { get; set; }
}
