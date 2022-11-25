﻿using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities;
using DataAccess.Abstract;


using Entities.Concrete;
using System;
using System.Collections.Generic;


namespace Business.Concrete
{
    public class CarManager : ICarService

    {
        ICarDal _CarDal;

        public CarManager(ICarDal carDal)
        {
            _CarDal = carDal;
        }

        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Cars car)
        {
            _CarDal.Add(car);
            return new SuccessResult(Messages.AddedCarMessage);

        }

        public IResult Delete(Cars car)
        {
            _CarDal.Delete(car);
            return new SuccessResult(Messages.DeletedCar);
        }

        public IDataResult<List<Cars>> GetAll()
        {

            return new SuccessDataResult<List<Cars>>(_CarDal.GetAll());

            //Console.WriteLine("Başarı ile Listelendi");
        }

        public IDataResult<List<Cars>> GetBrandId(int id)
        {
            return new SuccessDataResult<List<Cars>>(_CarDal.GetAll(c => c.BrandId == id));
        }

        public IDataResult<List<Cars>> GetColorId(int id)
        {
            return new SuccessDataResult<List<Cars>>(_CarDal.GetAll(c => c.ColorId == id));
        }

        public IResult Update(Cars car)
        {
            _CarDal.Update(car);
            return new SuccessResult(Messages.UpdateCar);
        }


    }
}
