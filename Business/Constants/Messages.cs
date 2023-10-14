using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        //******* CAR ***************
        public static string CarAdded = "Araba Başarıyla eklendi.";
        public static string CarDeleted = "Araba kaydı başarıyla silindi.";
        public static string CarUpdated = "Araba kaydı başarıla güncellendi.";
        public static string CarDetailBrought = "Araba getirildi.";

        public static string CarNameInvalid = "Araba ismi en az 2 karakter olmalıdır.";
        public static string CarDailyPriceInvalid = "Günlük Fiyatı sıfır olamaz.";
        public static string CarListed = "Arabalar listelendi.";
        public static string CarListedByBrand = "Arabalar markalara göre listelendi.";
        public static string CarListedByColor = "Arabalar renklerine göre listelendi.";


        //******* BRAND ***************
        public static string BrandAdded = "Marka Başarıyla eklendi.";
        public static string BrandDeleted = "Marka kaydı başarıyla silindi.";
        public static string BrandUpdated = "Marka kaydı başarıla güncellendi.";
        public static string BrandsListed = "Markalar listelendi.";

        //******* COLOR ***************
        public static string ColorAdded = "Renk Başarıyla eklendi.";
        public static string ColorDeleted = "Renk kaydı başarıyla silindi.";
        public static string ColorUpdated = "Renk kaydı başarıla güncellendi.";
        public static string ColorsListed = "Renkler listelendi.";

        //******* USER ***************
        public static string UserAdded = "Kullanıcı başarıyla eklendi.";
        public static string UserDeleted = "Kullanıcı kaydı başarıyla silindi.";
        public static string UserUpdated = "Kullanıcı kaydı başarıla güncellendi.";
        public static string UsersListed = "Kullanıcılar listelendi.";
        public static string UserDetailBrought = "Kullanıcı detayları getirildi.";

        //******* CUSTOMER ***************
        public static string CustomerAdded = "Müşteri başarıyla eklendi.";
        public static string CustomerDeleted = "Müşteri kaydı başarıyla silindi.";
        public static string CustomerUpdated = "Müşteri kaydı başarıla güncellendi.";
        public static string CustomersListed = "Müşteriler listelendi.";
        public static string CustomerDetailBrought = "Müşteri detayları getirildi.";

        //******* RENTAL ***************
        public static string RentalAdded = "Kiralama başarıyla eklendi.";
        public static string RentalDeleted = "Kiralama başarıyla silindi.";
        public static string RentalUpdated = "Kiralama başarıla güncellendi.";
        public static string RentalsListed = "Kiralamalar listelendi.";
        public static string RentalDetailBrought = "Kiralama detayları getirildi.";

        public static string Unrentable = "Kiralamaya uygun değildir.";

    }
}
