using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        //id
        public int Id { get; set; }
        //ketogeri id
        public int CategoryId { get; set; }
        //isim
        public string ProductName { get; set; }
        //fiyat
        public double UnitPrice { get; set; }
        //stok adedi
        public int UnitInStock { get; set; }

    }
}
