using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AP205ApiPractice.Dtos.ProductDtos
{
    public class ProductPostDto
    {
        public string Name { get; set; }
        public double CostPrice { get; set; }
        public double SalePrice { get; set; }
    }
}
