using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    //static mimlemeyi önlüyo mesajlar sabit olduğundan yazdık
    public static class Messages
    {
        public static string ProductNameAlreadyExists="Ürün ismi zaten kayıtlı...";
        public static string ProductCountOfCategoryError = "Ürün kategorisinde fazla ürün oldu...";
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün İsmi Geçersiz...";
        public static string MaintenanceTime = "Bakım Zamanı...";
        public static string ProductsListed = "Ürünler Listelendi...";
        public static string UnitPriceInvalid = "Ürün fiyatı geçersiz.";
    }
}
