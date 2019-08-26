using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Itinere.Infrastructure.Model
{
    public class Footprint
    {
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }

        public Dung MorningDung { get; set; }
    }
}
