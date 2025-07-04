using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class character_gremory_case
{
    public int guid { get; set; }

    public byte[]? gremory_case_char { get; set; }

    public byte[]? gremory_case_mobile { get; set; }

    public byte[]? gremory_case_ps { get; set; }
}
