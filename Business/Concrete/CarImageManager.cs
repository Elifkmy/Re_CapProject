using Business.Abstract;
using Business.Business_Aspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Helpers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;

namespace Business.Concrete
{
    //public class CarImageManager : ICarImageService
    //{
    //    ICarImageDal _carImageDal;

    //    public CarImageManager(ICarImageDal carImageDal)
    //    {
    //        _carImageDal = carImageDal;
    //    }

        
    //    public IResult Add(IFormFile file, CarImage carImage)
    //    {
    //        var result = BusinessRules.Run(CheckIfCarImageLimitExceeded(carImage));

    //        if (result != null)
    //        {
    //            return result;
    //        }

    //        carImage.ImagePath = ImageWriterHelper.UploadImage(file);
    //        _carImageDal.Add(carImage);

    //        return new SuccessResult(Messages.CarImageAdded);
    //    }

        
    //    public IResult Delete(CarImage carImage)
    //    {
    //        var usedpath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\wwwroot")) + _carImageDal.Get(ci=>ci.CarImageId==carImage.CarImageId).ImagePath;

    //        var result = BusinessRules.Run(ImageWriterHelper.Delete(usedpath));

    //        if (result != null)
    //        {
    //            return result;
    //        }

    //        _carImageDal.Delete(carImage);
    //        return new SuccessResult(Messages.CarImageDeleted);
    //    }

    //    public IDataResult<List<CarImage>> GetAll()
    //    {
    //        return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(), Messages.CarImageListed);
    //    }

        
    //    public IDataResult<CarImage> GetById(int id)
    //    {
    //        return new SuccessDataResult<CarImage>(_carImageDal.Get(c => c.CarImageId == id));
    //    }

    //    public IDataResult<List<CarImage>> GetCarImagesById(int carId)
    //    {
    //        return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(c => c.CarId == carId));
    //    }

        
    //    public IResult Update(IFormFile file, CarImage carImage)
    //    {
    //        var usedpath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\wwwroot")) + _carImageDal.Get(up=>up.CarImageId == carImage.CarImageId).ImagePath;
    //        carImage.ImagePath = ImageWriterHelper.Update(file,usedpath);
    //        carImage.Date = DateTime.Now;
    //        _carImageDal.Update(carImage);
    //        return new SuccessResult();
    //    }

    //    private IResult CheckIfCarImageLimitExceeded(CarImage carImage)
    //    {
    //        var result = _carImageDal.GetAll(c => c.CarId == carImage.CarId);
    //        if (result.Count>=5)
    //        {
    //            return new ErrorResult(Messages.CarImageLimit);
    //        }
    //        return new SuccessResult();
    //    }
    //}
}
