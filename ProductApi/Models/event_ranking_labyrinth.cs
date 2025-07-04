using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class event_ranking_labyrinth
{
    public uint char_id { get; set; }

    public ushort? level { get; set; }

    public byte? stage { get; set; }

    public byte? index { get; set; }

    public int? killed_monsters { get; set; }

    public long? earned_experience { get; set; }

    public int? completed_missions { get; set; }

    public int? score { get; set; }
}
