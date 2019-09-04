using Microsoft.EntityFrameworkCore;
using System;

namespace Itinere.Infrastructure.Model
{
    public class CoffeeTime
    {
        //public string Id { get; set; }
        public string With { get; set; }
        public DateTime When { get; set; }

        public Footprint Footprint { get; set; }
    }
}
