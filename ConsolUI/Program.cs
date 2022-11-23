using Business.Abstract;
using Business.Concrete;
using Core.Utilities;
using Core.Utilities.Helpers.FileHelper;
using DataAccess.Abstract;
using DataAccess.Concrete.Entity_Freamwork;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace ConsolUI
{
    public class Program
    {

        public static void Main()
        {
            //------------------------------------Araç Ekleme---------------------------



            //CarManager carManager = new CarManager(new EfCarDal());
            //Cars cars = new Cars();
            //{
            //    Id = 2,BrandId = 3,ColorId = 1,DailyPrice = 250,Description = "Dünyada Bir Numara",ModelYear = "2020";
            //};
            //carManager.Add(cars);
            //---------------------------------------------------------------------------------------------------------------------------------------------------




            //------------Araç Renk Ekleme-----------------------------------


            // ColorManager colorManager = new ColorManager(new EfColorDal());
            //Color color = new Color
            //{
            //    ColorId = 6,
            //    Name = "Beyaz"
            //};

            //colorManager.Add(color);
            //---------------------------------------------------------------------------------------------------------------------------------------------------

            //--------------------------Araç Marka Ekleme----------------------------

            //BrandManager brandManager = new BrandManager(new EfBrandDal());
            //Brand brand = new Brand()
            //{
            //    BrandId = 5,
            //    Name = "Hyundai",

            //};
            //brandManager.Add(brand);
            //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            //----------------Araç Silme------------------

            /*CarManager carManager = new CarManager(new EfCarDal());
            Cars cars = new Cars()
            {
                BrandId = 1,ColorId = 1, DailyPrice=5,Description="asc",Id=2,ModelYear="2013"
            };
            carManager.Delete(cars);*/
            //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            //---------Renk Silme----------
            //Color color = new Color
            //{
            //    ColorId = 8,

            //};
            //colorManager.Delete(color);
            //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            //------------Marka Silme------------

            //Brand brand = new Brand()
            //{
            //    BrandId = 8,
            //};
            //brandManager.Delete(brand);
            //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            //----------------Araç Güncelleme--------------------

            //Cars cars = new Cars
            //{
            //    Id = 1,
            //    BrandId = 1,
            //    ColorId = 2,
            //    ModelYear = "2017",
            //    DailyPrice = 175,
            //    Description = "Benzin"

            //};
            //carManager.Update(cars);

            //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            //--------------Marka Güncelleme--------------
            //Brand brand = new Brand()
            //{
            //    BrandId = 7,
            //    Name = "Fiat"
            //};
            //brandManager.Update(brand);

            //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            // --------------renk güncelleme----------------
            //Color color = new Color
            //{
            //    ColorId = 8,
            //    Name = "turkuaz"
            //};
            //colorManager.Update(color);


            //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            ////--------------Araç Listele--------------
            //CarManager carManager = new CarManager(new EfCarDal());



            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine("Marka: " + car.BrandId);
            //    Console.WriteLine("Model: " + car.ModelYear);
            //    Console.WriteLine("Günlük Fiyat: " + car.DailyPrice);
            //    Console.WriteLine("Yakıt: " + car.Description);
            //    Console.WriteLine("Renk: " + car.ColorId);

            //}


            //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            //--------------Marka Listele-----------------

            //foreach (var item in brandManager.GetAll())
            //{
            //    Console.WriteLine("MarkaId="+item.BrandId + "----->" +"Marka Adı="+ item.Name);

            //}

            //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            //----------Renk Listele-------------

            //foreach (var color in colorManager.GetAll())
            //{
            //    Console.WriteLine("RenkId= "+color.ColorId + "------>" + "Renk= " + color.Name);
            //}

            //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            //RentalManager rentalManager = new RentalManager(new EfRentalDal());
            //Rental rental = new Rental() { CarId = 1, CustomerId = 1, Kiralandi = false, RenTime = DateTime.Now, ReturnTime = DateTime.Now.AddDays(2),RentalId=5 };
            //rentalManager.Add(rental);



            //yukardaki managerları kullandım tekrar newlemedim
            //Carmanager.getall string tipi sorunu var 

            var c = new CarManager(new EfCarDal()).GetAll();
            foreach (Cars item in c.Data)
            {
                Console.WriteLine(item.BrandId);
            }
        }
    }

}



