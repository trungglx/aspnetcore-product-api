using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class party_member
{
    public uint member { get; set; }

    public ushort? server { get; set; }

    public ushort? party { get; set; }

    public byte? position { get; set; }
}
