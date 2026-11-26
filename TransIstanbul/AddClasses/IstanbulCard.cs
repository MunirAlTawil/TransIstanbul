using System;
using System.Collections.Generic;

#nullable disable

namespace TransIstanbul.AddClasses
{
    public partial class IstanbulCard
    {
        public int CardId { get; set; }
        public string CustomerType { get; set; }
        public string CustomerName { get; set; }
        public int? CustomerId { get; set; }
        public double? Balance { get; set; }
    }
}
