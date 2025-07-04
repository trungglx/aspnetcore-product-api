using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class item_recovery
{
    public uint char_id { get; set; }

    public ushort item { get; set; }

    public byte? level { get; set; }

    public byte? durability { get; set; }

    public byte? skill { get; set; }

    public byte? luck { get; set; }

    public byte? option { get; set; }

    public byte? excellent { get; set; }

    public byte? ancient { get; set; }

    public byte? harmony { get; set; }

    public byte? option_380 { get; set; }

    public ushort? socket_1 { get; set; }

    public ushort? socket_2 { get; set; }

    public ushort? socket_3 { get; set; }

    public ushort? socket_4 { get; set; }

    public ushort? socket_5 { get; set; }

    public byte? socket_bonus { get; set; }

    public int? data_1 { get; set; }

    public int? data_2 { get; set; }

    public int? data_3 { get; set; }

    public ushort? serial_server { get; set; }

    public uint? serial { get; set; }

    public uint? serial_cash_shop { get; set; }

    public uint? flags { get; set; }

    public uint? id { get; set; }
}
