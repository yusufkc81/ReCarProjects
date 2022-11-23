using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {

        //Brandmanager
        public static string BrandsListed = "Markalar Listelendi";
        public static string UpdateBrand = "Marka Güncellendi";
        public static string DeletedBrand = "Marka Silindi";
        public static string AddedBrand = "Marka Eklendi";

        //ColorManager
        public static string AddedColor = "Renk Eklendi";
        public static string DeletedColor = "Renk Silindi";
        public static string UpdateColor = "Renk Güncellendi";
        public static string ColorListed = "Renkler listelendi";

        //UserManager
        public static string AddedUser = "Kullanıcı Eklendi";
        public static string DeletedUser = "Kullanıcı Silindi";
        public static string UsersListed = "Kullanıcı Listelendi";
        public static string UpadateUser = "Kullanıcı Güncellendi";

        //CustomerManager
        public static string AddedCustomer = "Müşteri Eklendi";
        public static string DeletedCustomer = "Müşteri Silindi";
        public static string UptadeCustomer = "Müşteri Güncellendi";
        public static string CustomerListed = "Müşeteri Listelendi";

        //RentalManager
        public static string AddedRental = "Kiralama Eklendi";
        public static string DeletedRental = "Kiralama Silindi";
        public static string UpdateRental = "Kiralama Güncellendi";
        public static string RentalListed = "Kiralamalar Listelendi";
        public static string ErorrAddedRental = "Boş değer Bırakmayanız.";
        public static string ErrorReturnAddedRental = "Araç Kiralanmış durumdadır.";

        //CarImageManager
        public static string AddedCarImage = "Resim Eklendi";
        public static string DeletedCarImage ="Resim Silindi";
        public static string CarImagesListed = "Resimler listelendi";
        public static string UpdatedCarImage = "Resimler Güncellendi";

        //Carmanager
        public static string AddedCarMessage = "Araç Eklendi";
        public static string UpdateCar = "Araç Güncellendi";
        public static string DeletedCar = "Araç Silindi";
        public static string CarListed = "Araçlar Listelendi";
        public static string ErorrAddedCar = "Araba ekeleyemezzsiniz";


    }
}
