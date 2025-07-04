using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class character_helper
{
    public uint char_id { get; set; }

    public uint? option_flag_1 { get; set; }

    public uint? option_flag_2 { get; set; }

    public byte? item_pick_flag { get; set; }

    public byte? hunting_range { get; set; }

    public byte? item_pick_range { get; set; }

    public ushort? distance { get; set; }

    public ushort? attack_skill_1 { get; set; }

    public ushort? attack_sec_skill_1 { get; set; }

    public ushort? attack_sec_skill_2 { get; set; }

    public ushort? attack_sec_delay_1 { get; set; }

    public ushort? attack_sec_delay_2 { get; set; }

    public ushort? buff_skill_1 { get; set; }

    public ushort? buff_skill_2 { get; set; }

    public ushort? buff_skill_3 { get; set; }

    public ushort? time_space_casting { get; set; }

    public byte? percent_autopot { get; set; }

    public byte? percent_autoheal { get; set; }

    public byte? percent_partyheal { get; set; }

    public byte? percent_drainlife { get; set; }

    public string? item_list { get; set; }

    public ushort? buff_item_1 { get; set; }

    public ushort? buff_item_2 { get; set; }

    public ushort? buff_item_3 { get; set; }

    public ushort? buff_skill_4 { get; set; }

    public ushort? buff_skill_5 { get; set; }

    public ushort? buff_skill_6 { get; set; }
}
