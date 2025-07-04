using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class character_event_count
{
    public uint char_id { get; set; }

    public byte event_id { get; set; }

    public byte? count { get; set; }

    public byte day { get; set; }
}
