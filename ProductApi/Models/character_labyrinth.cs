using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class character_labyrinth
{
    public uint char_id { get; set; }

    public byte? stage { get; set; }

    public byte? id { get; set; }

    public ushort? level { get; set; }

    public byte? status { get; set; }

    public int? killed_monsters { get; set; }

    public long? earned_experience { get; set; }

    public int? completed_missions { get; set; }

    public long? date { get; set; }

    public byte? goblin_state { get; set; }

    public byte? day_first { get; set; }
}
