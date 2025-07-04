using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class lo_de
{
    public int id { get; set; }

    public int account_id { get; set; }

    public int char_id { get; set; }

    public int bet_number { get; set; }

    public int bet_type { get; set; }

    public int bet_item { get; set; }

    public int bet_value { get; set; }

    public DateTime bet_time { get; set; }

    public int reward_value_x { get; set; }

    public int reward_status { get; set; }
}
