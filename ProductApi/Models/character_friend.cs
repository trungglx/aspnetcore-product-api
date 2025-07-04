using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class character_friend
{
    public uint char_id { get; set; }

    public string friend_name { get; set; } = null!;
}
