using Business.Abstract;
using Business.Constants;
using Core.Utilities;
using Core.Utilities.Helpers.FileHelper;
using DataAccess.Abstract;
using DataAccess.Concrete.Entity_Freamwork;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarImageManager:ICarImageService
    {
        //IFileHelper _fileHelper;
        ICarImageDal _carImageDal;
        public CarImageManager(ICarImageDal carImageDal/*,IFileHelper fileHelper*/)
        {
            _carImageDal = carImageDal;
            //_fileHelper = fileHelper;
        }

        public IResult Add(/*IFormFile file,*/CarImages carImages)
        {
            //carImages.ImagePath = _fileHelper.Upload(file, PathConstants.ImagesPath);
            //carImages.Date = DateTime.Now;
            _carImageDal.Add(carImages);
            return new SuccessResult(Messages.AddedCarImage);
        }

        public IResult Delete(/*IFormFile file,*/ CarImages carImages)
        {
            //_fileHelper.Delete(PathConstants.ImagesPath);
            _carImageDal.Delete(carImages); 
            return new SuccessResult(Messages.DeletedCarImage); ;
        }

        public IDataResult<List<CarImages>> GetAll()
        {
            return new SuccessDataResult<List<CarImages>>(_carImageDal.GetAll());
        }

        public IResult Update(/*IFormFile file, */CarImages carImages)
        {
            //carImages.ImagePath=_fileHelper.Update(file, PathConstants.ImagesPath+carImages.ImagePath,PathConstants.ImagesPath);
            _carImageDal.Add(carImages);
            return new SuccessResult(Messages.UpdatedCarImage);
        }
    }
}
