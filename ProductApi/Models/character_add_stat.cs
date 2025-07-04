using System;
using System.Collections.Generic;

namespace ProductApi.Models;

public partial class character_add_stat
{
    public int? GUID { get; set; }

    public int Strenght { get; set; }

    public int Agility { get; set; }

    public int Vitality { get; set; }

    public int Energy { get; set; }

    public int Leadership { get; set; }
}
