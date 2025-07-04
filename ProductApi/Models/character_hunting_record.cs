using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class character_hunting_record
{
    public uint char_id { get; set; }

    public ushort world { get; set; }

    public ushort? year { get; set; }

    public byte? month { get; set; }

    public byte? day { get; set; }

    public uint? level { get; set; }

    public uint? duration { get; set; }

    public ulong? damage { get; set; }

    public ulong? elemental_damage { get; set; }

    public uint? healing { get; set; }

    public uint? killed_count { get; set; }

    public ulong? earned_experience { get; set; }
}
