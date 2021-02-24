using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda olduğu için işleminizi gerçekleştiremiyoruz.";
        public static string ProductListed = "Ürünler listelendi";
        public static string UnitPriceInvalid = "Ürünün fiyatı 0 tl den büyük olmalıdır.";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir.";
        public static string ProductNameAlreadyExists = "Bu isimde zaten sisteme kayıtlı başka bir ürün var.";
        public static string CategoryLimitExceded = "Kategori limiti aşıldı.";
    }
}


