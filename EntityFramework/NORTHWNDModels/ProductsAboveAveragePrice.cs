using System;
using System.Collections.Generic;

namespace EntityFramework.NORTHWNDModels
{
    public partial class ProductsAboveAveragePrice
    {
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
    }
}
