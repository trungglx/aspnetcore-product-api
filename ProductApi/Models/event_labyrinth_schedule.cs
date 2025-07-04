using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class event_labyrinth_schedule
{
    public ushort server { get; set; }

    public byte? state { get; set; }

    public long? start_date { get; set; }
}
