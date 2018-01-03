using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierApplication.Entity.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public short Stock { get; set; }

        public int? CategoryId { get; set; } //Null geçilebilir alan

        public Category Category { get; set; }


    }
}
