using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class giant_mount_setting
{
    public long character_id { get; set; }

    public short giant_model { get; set; }

    public short giant_status { get; set; }
}
