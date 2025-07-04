using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class account_warehouse
{
    public uint account_id { get; set; }

    public uint? money { get; set; }

    public ushort? password { get; set; }

    public byte[]? inventory { get; set; }

    public byte[]? gremory_case_acc { get; set; }

    public string? wingcoreinventory { get; set; }
}
