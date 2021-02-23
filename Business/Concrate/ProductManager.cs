using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entites.Concrete;
using Entites.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class ProductManager : IProductServise
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IResult Add(Product product)
        {
            if (product.ProductName.Length < 2)
            { // magic string
                return new ErrorResult(Messages.ProductNameInvalid);
            }
            _productDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IDateResult<List<Product>> GetAll()
        {if (DateTime.Now.Hour == 22)
            {
                return new ErrorDateResult<List<Product>>(Messages.MaintenanceTime);
            }
            return new SuccessDateResult<List<Product>> (_productDal.GetAll() ,Messages.ProductsListed);
        }

        public IDateResult<List<Product>> GetAllByCategoryId(int id)
        {
            return new SuccessDateResult<List<Product>>( _productDal.GetAll(p => p.CategoryId == id));
        }

        public IDateResult<Product> GetById(int productId)
        {
            return new SuccessDateResult<Product>(_productDal.Get(p => p.ProductId == productId));
        }

        public IDateResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
        {
            return new SuccessDateResult<List<Product>>
                (  _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max));
        }

        public IDateResult<List<ProductDetailDto>> GetProductDetails()
        {
            return new SuccessDateResult<List<ProductDetailDto>>(_productDal.GetProductDetails());
        }

       
    }
}
