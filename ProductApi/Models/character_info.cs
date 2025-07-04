using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class character_info
{
    public uint guid { get; set; }

    public uint? account_id { get; set; }

    public byte? authority { get; set; }

    public ushort? race { get; set; }

    public string? name { get; set; }

    public sbyte? slot { get; set; }

    public short? level { get; set; }

    public short? level_master { get; set; }

    public short? level_majestic { get; set; }

    public long? experience { get; set; }

    public long? experience_master { get; set; }

    public long? experience_majestic { get; set; }

    public int? points { get; set; }

    public int? points_master { get; set; }

    public int? points_majestic { get; set; }

    public uint? strength { get; set; }

    public uint? agility { get; set; }

    public uint? vitality { get; set; }

    public uint? energy { get; set; }

    public uint? leadership { get; set; }

    public ushort? world { get; set; }

    public short? world_x { get; set; }

    public short? world_y { get; set; }

    public byte? direction { get; set; }

    public uint? money { get; set; }

    public int? life { get; set; }

    public int? mana { get; set; }

    public int? shield { get; set; }

    public int? stamina { get; set; }

    public int? add_fruit_points { get; set; }

    public int? dec_fruit_points { get; set; }

    public byte? expanded_inventory { get; set; }

    public long? mute_time { get; set; }

    public uint? admin_flags { get; set; }

    public byte? pk_level { get; set; }

    public int? pk_count { get; set; }

    public int? pk_points { get; set; }

    public byte? first_time { get; set; }

    public long? santa_claus_gift { get; set; }

    public string? personal_store_name { get; set; }

    public sbyte? personal_store_open { get; set; }

    public long? last_use { get; set; }

    public long? kick_time { get; set; }

    public int? post_count { get; set; }

    public byte? post_day { get; set; }

    public byte? post_month { get; set; }

    public uint? ruud_money { get; set; }

    public byte? hunting_log_visible { get; set; }

    public long? create_date { get; set; }

    public sbyte? online { get; set; }

    public ushort? server_code { get; set; }

    public uint? reset { get; set; }

    public int? monster_soul_purchase { get; set; }

    public int? lastserver { get; set; }
}
