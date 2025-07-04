using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class character_chat_block
{
    public uint char_id { get; set; }

    public string? blocked { get; set; }
}
