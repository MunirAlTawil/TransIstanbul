using System;
using System.Collections.Generic;

#nullable disable

namespace TransIstanbul.AddClasses
{
    public partial class BlueCard
    {
        public int CardId { get; set; }
        public string CustomerName { get; set; }
        public int? CustomerId { get; set; }
        public double? Points { get; set; }
    }
}
