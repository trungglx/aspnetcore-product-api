using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class accounts_status
{
    public uint account_id { get; set; }

    public ushort? server_group { get; set; }

    public ushort? current_server { get; set; }

    public ushort? start_server { get; set; }

    public short? dest_server { get; set; }

    public short? dest_world { get; set; }

    public short? dest_x { get; set; }

    public short? dest_y { get; set; }

    public uint? warp_time { get; set; }

    public uint? warp_auth_1 { get; set; }

    public uint? warp_auth_2 { get; set; }

    public uint? warp_auth_3 { get; set; }

    public uint? warp_auth_4 { get; set; }

    public string? last_ip { get; set; }

    public string? last_mac { get; set; }

    public string? last_online { get; set; }

    public sbyte? online { get; set; }

    public uint? disk_serial { get; set; }

    public byte? type { get; set; }
}
