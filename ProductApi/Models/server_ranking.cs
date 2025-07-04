using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class server_ranking
{
    public int guid { get; set; }

    public int? race { get; set; }

    public int? level_normal { get; set; }

    public int? level_master { get; set; }

    public int? level_majestic { get; set; }

    public int? reset { get; set; }

    public DateTime? update_time { get; set; }
}
