using Entites.Concrete;
using Entites.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductServise
    {
        List<Product> GetAll();
        List<Product> GetAllByCategoryId(int id);// kategoriid göre getir
        List<Product> GetByUnitPrice(decimal min, decimal max);

        List<ProductDetailDto> GetProductDetails();
    }
}
