using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class item_serial
{
    public int server { get; set; }

    public long serial { get; set; }

    public long serial_shop { get; set; }
}
