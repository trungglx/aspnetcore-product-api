using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class account_datum
{
    public uint account_id { get; set; }

    public int? vip_status { get; set; }

    public long? vip_duration { get; set; }

    public byte? expanded_warehouse { get; set; }

    public long? expanded_warehouse_time { get; set; }

    public ushort? special_character { get; set; }

    public uint? credits { get; set; }

    public uint? web_credits { get; set; }

    public uint? current_character { get; set; }

    public byte? current_type { get; set; }

    public string? current_ip { get; set; }

    public string? current_mac { get; set; }

    public uint? current_diskserial { get; set; }

    public ushort? current_server { get; set; }

    public byte? cash_shop_discount_wc { get; set; }

    public byte? cash_shop_discount_gp { get; set; }

    public long? cash_shop_discount_date { get; set; }

    public int? goblin_points { get; set; }
}
