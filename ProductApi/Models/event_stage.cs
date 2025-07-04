using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class event_stage
{
    public byte event_id { get; set; }

    public byte? stage { get; set; }
}
