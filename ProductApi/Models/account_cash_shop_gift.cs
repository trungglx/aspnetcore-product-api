using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class account_cash_shop_gift
{
    public uint account_id { get; set; }

    public uint product { get; set; }

    public uint option { get; set; }

    public uint serial { get; set; }

    public uint serial_cash_shop { get; set; }

    public ushort server { get; set; }

    public long date { get; set; }
}
