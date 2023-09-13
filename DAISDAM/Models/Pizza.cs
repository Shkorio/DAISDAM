using System;
using System.Collections.Generic;

namespace DAISDAM.Models
{
    public partial class Pizza
    {
        public int Id { get; set; }
        public string? Components { get; set; }
        public string? Sousu { get; set; }
        public int? Count { get; set; }
        public decimal? Cost { get; set; }
    }
}
