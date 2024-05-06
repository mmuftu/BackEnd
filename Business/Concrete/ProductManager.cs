﻿using Business.Abstract;
using Business.Contants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        public ProductManager(IProductDal productDal) 
        {
            _productDal = productDal;

        }
        public IResult Add(Product product)
        {
            _productDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IResult Delete(Product product)
        {
           _productDal.Delete(product);
            return new SuccessResult(Messages.ProductDeleted);
        }

        public IDataResult<Product> GetById(int productid)
        {
            return  new SuccessDataResult<Product>    ( _productDal.Get(p => p.ProductID == productid));
        }   

        public IDataResult <List<Product>> GetList()
        {
            return new SuccessDataResult<List<Product>>(  _productDal.GetList().ToList());
        }

        public IDataResult<List<Product>> GetListByCategory(int categoryID)
        {
           return new SuccessDataResult<List<Product>>(_productDal.GetList(p=>p.CategoryID == categoryID).ToList()) ;
        }

        public IResult Update(Product product)
        {
           _productDal.Update(product);
            return new SuccessResult(Messages.ProductUpdated);
        }
    }
}
