using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Helpers.FileHelper;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _imageDal;

        public CarImageManager(ICarImageDal imageDal)
        {
            _imageDal = imageDal;
        }

        public IResult Add(IFormFile file, CarImage carImage)
        {
            IResult result = BusinessRules.Run(
                CheckUploadedImagesLimit(carImage.CarId)
                );

            if (result != null)
            {
                return result;
            }

            var imageResult = FileHelper.Upload(file);

            if (!imageResult.IsSuccess)
            {
                return new ErrorResult(imageResult.Message);
            }
            carImage.ImagePath = imageResult.Message;
            _imageDal.Add(carImage);
            return new SuccessResult(Messages.ImageAdded);
        }

        public IResult Delete(CarImage carImage)
        {
            var image = _imageDal.Get(p => p.ImageId == carImage.ImageId);

            if (image==null)
            {
                return new ErrorResult(Messages.CarImageDefault);
            }

            FileHelper.Delete(image.ImagePath);
            _imageDal.Delete(carImage);
            return new SuccessResult();
        }

        public IDataResult<CarImage> GetById(int imageId)
        {
            return new SuccessDataResult<CarImage>(_imageDal.Get(i => i.ImageId == imageId));
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_imageDal.GetAll());
        }

        public IDataResult<List<CarImage>> GetByCarId(int carId)
        {
            var result = BusinessRules.Run(CheckIfExistImage(carId));
            if (result != null)
            {
                return new ErrorDataResult<List<CarImage>>(GetDefaultImage(carId).Data);
            }
            return new SuccessDataResult<List<CarImage>>(_imageDal.GetAll(p => p.CarId == carId));
        }

        public IResult Update(IFormFile file, CarImage carImage)
        {
            var isImage = _imageDal.Get(i=>i.ImageId == carImage.ImageId);

            if (isImage == null)
            {
                return new ErrorResult(Messages.CarImageDefault);
            }

            var updateFile = FileHelper.Update(file, isImage.ImagePath);
            if (!updateFile.IsSuccess)
            {
                return new ErrorResult(updateFile.Message);
            }

            carImage.ImagePath = updateFile.Message;
            _imageDal.Update(carImage);
            return new SuccessResult();
        }


        //BUSİNESS RULES
        //*************
        private IResult CheckUploadedImagesLimit(int carId)
        {
            var carImagecount = _imageDal.GetAll(p => p.CarId == carId).Count;
            if (carImagecount >= 5)
            {
                return new ErrorResult(Messages.ImageUploadLimitOver);
            }

            return new SuccessResult();
        }

        private IResult CheckIfExistImage(int carId)
        {
            var result = _imageDal.GetAll(c => c.CarId == carId).Any();
            if (result)
            {
                return new SuccessResult();
            }
            return new ErrorResult();

        }

        private IDataResult<List<CarImage>> GetDefaultImage(int carId)
        {
            List<CarImage> carimage = new List<CarImage>();
            carimage.Add(new CarImage { CarId = carId, ImagePath = "/Images/logo.png" });
            return new SuccessDataResult<List<CarImage>>(carimage);

        }
    }
}
