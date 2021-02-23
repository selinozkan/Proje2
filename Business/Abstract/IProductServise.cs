using Core.Utilities.Results;
using Entites.Concrete;
using Entites.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductServise
    {

        IDateResult<List<Product>> GetAll();
        IDateResult<List<Product>> GetAllByCategoryId(int id);// kategoriid göre getir
        IDateResult<List<Product>> GetByUnitPrice(decimal min, decimal max);

        IDateResult<List<ProductDetailDto>> GetProductDetails();

        IDateResult<Product>GetById(int productId); // ürünün detayı
        IResult Add(Product product);
    }

}
