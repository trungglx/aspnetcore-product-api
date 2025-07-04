using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class character_notification
{
    public ushort server_group { get; set; }

    public string? char_name { get; set; }

    public string? facebook_id { get; set; }

    public string? notification_id { get; set; }

    public string? notification_data { get; set; }
}
