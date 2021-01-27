using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //snippet -hazır kod
    class Product 
        //bu tip classlarda sadece özellik olur
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        //ürünün fiyatı
        public double UnitPrice { get; set; }
        //ürünün stok adedi
        public int UnitsInStock { get; set; }

    }
}
