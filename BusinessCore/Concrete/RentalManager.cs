using Business.Abstract;
using Business.Constants;
using Core.Utilities;
using Core.Utilities.Business;
using DataAccess.Abstract;
using DataAccess.Concrete.Entity_Freamwork;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace Business.Concrete
{
    public class RentalManager:IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        
        {

            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            //iş kuralı tek tek hereyere yazmak yerine metot şeklinde çağırıyoruzki tekrar tekrar yazmaylalım
            //burda iş kuralı metodu bu classın 181 inci satırında bulunmakta iş kuralı araba kiralama günü bitmemeişse kiralanamazdır
            IResult result = BusinessRules.Run(GetCheckAddedRental(rental.CarId));
            if (result !=null)
            {
                return result;
            }

            _rentalDal.Add(rental);
            return new SuccessResult(Messages.AddedRental);

          





            //if (rental == null)
            //{
            //    return new ErrorResult(Messages.ErorrAddedRental);
            //}
            //else
            //{
            //    var result = _rentalDal.GetAll(r => r.CarId == rental.CarId);
            //    var bak = 0;
            //    foreach (var item in result)
            //    {
            //        if (item.ReturnTime > item.RenTime)
            //        {
            //            bak++;
            //        }

            //    }
            //    if (bak == result.Count)
            //    {
            //        _rentalDal.Add(rental);
            //        return new SuccessResult(Messages.AddedRental);

            //    }
            //    return new ErrorResult(Messages.ErrorReturnAddedRental);
            //}

        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.DeletedRental);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(),Messages.RentalListed);
        }

        public IDataResult<List<Rental>> GetCarId(int id)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(c => c.CarId == id));
        }

        public IDataResult<List<Rental>> GetUserId(int id)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(c => c.UserId == id));
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.UpdateRental);
        }

        public IResult GetCheckAddedRental(int CarId)
        {

            var x = _rentalDal.GetAll(c => c.ReturnTime > DateTime.Now);
            foreach (var item in x)
            {
                if (item.CarId == CarId)
                {
                    return new ErrorResult(Messages.ErorrAddedRental);
                }
            }
            return new SuccessResult(Messages.AddedRental);
        }

        public IDataResult<List<RentalDTO>> GetDtos()
        {
            return new SuccessDataResult<List<RentalDTO>>(_rentalDal.GetRentalDTOs(), Messages.SuccessGetCarDetailsMessage);
        }
    }

}
