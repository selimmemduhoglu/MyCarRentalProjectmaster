﻿using Core.Utilities.Result;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IResult Add(Customer customer);
        IResult Update(Customer customer);
        IResult Delete(Customer customer);
        IDataResult<Customer> GetById(int id);
        IDataResult<Customer> GetByUserId(int userId);
        IDataResult<List<Customer>> GetAll();


        IResult FakeCustomerAdd(int userId);
    }
}
