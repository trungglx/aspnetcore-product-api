using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class party
{
    public ushort guid { get; set; }

    public ushort? server { get; set; }
}
