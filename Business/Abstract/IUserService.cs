﻿using Core.Utilities.Result;
using Entitiy.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetById(int Id);
        IResult Add(User user);

        IResult Delete(User user);

        IResult Update(User user);
    }
}