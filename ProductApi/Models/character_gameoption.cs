using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class character_gameoption
{
    public uint char_id { get; set; }

    public byte? game_option { get; set; }

    public byte? chat_window { get; set; }

    public byte? q_key { get; set; }

    public byte? w_key { get; set; }

    public byte? e_key { get; set; }

    public byte? r_key { get; set; }

    public int? qwer_level { get; set; }

    public ushort? skill_bind_0 { get; set; }

    public ushort? skill_bind_1 { get; set; }

    public ushort? skill_bind_2 { get; set; }

    public ushort? skill_bind_3 { get; set; }

    public ushort? skill_bind_4 { get; set; }

    public ushort? skill_bind_5 { get; set; }

    public ushort? skill_bind_6 { get; set; }

    public ushort? skill_bind_7 { get; set; }

    public ushort? skill_bind_8 { get; set; }

    public ushort? skill_bind_9 { get; set; }

    public ulong? extra_data { get; set; }

    public byte? change_skin { get; set; }

    public ushort? additional_options { get; set; }

    public byte? button_bind_1 { get; set; }

    public byte? button_bind_2 { get; set; }

    public byte? button_bind_3 { get; set; }

    public byte? button_bind_4 { get; set; }

    public byte? button_bind_5 { get; set; }
}
