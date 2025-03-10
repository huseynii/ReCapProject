﻿using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);
        IDataResult<List<User>> GetAll();
        IDataResult<User> Get(int id);
        //IDataResult<List<OperationClaim>> GetClaims(User user);
        //IDataResult<User> GetByMail(string email);
        List<OperationClaim> GetClaims(User user);
        // void Add(User user);
        User GetByMail(string email);
    }
}
